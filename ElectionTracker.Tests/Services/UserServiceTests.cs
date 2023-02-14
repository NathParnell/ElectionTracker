using ElectionTracker.Classes;
using ElectionTracker.Services;
using ElectionTracker.Services.Infrastructure;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ElectionTracker.Tests.Services
{
    public class UserServiceTests
    {
        private readonly Mock<IDataService> _dataServiceMock = new Mock<IDataService>();


        private readonly User _testUser = new User(
            "John",
            "Smith",
            "30-38 Dock Street, Leeds",
            "LS10 1JF",
            DateTime.Now,
            "c1040085@my.hallam.ac.uk");

        private readonly IUserService _sut;

        public UserServiceTests() 
        {
            _sut = new UserService(_dataServiceMock.Object);
        }


        [Fact]
        public void TestCreateAccount()
        {
            //Arrange
            _dataServiceMock.Setup(t => t.CreateUser(It.IsAny<User>()));
            _dataServiceMock.Setup(t => t.GetUserByUserID(It.IsAny<string>())).Returns(_testUser);

            //Act
            bool actual = _sut.CreateAccount(_testUser.Forename,
            _testUser.Surname,
            _testUser.Address,
            _testUser.Postcode,
            _testUser.DateOfBirth,
            _testUser.Password,
            "Test1234!");

            //Assert
            Assert.True(actual);
            Assert.Equal(_testUser.Email, _sut.CurrentUser.Email);
        }

        [Fact]
        public void TestAttemptLogin()
        {
            //Arrange
            _dataServiceMock.Setup(t => t.GetPasswordSalt(It.IsAny<string>())).Returns("qµQ\u001bæ¿UZƒBÚ\u0081S°Sðôrw‚Y©\fƒ\u0011\u000e€kùÉouÀŒ0qSÀ|¨69ãœí`\u0011¿aNÃ³²½\v\u008dUÁ€‘—7ká\u0081»Ùóä\tØ\f_ ‰\u0003ž\t<¢›¨e\u009d~?}ý¯7{ïë²\u0081”r‡Ùx\u001dlK¼5Ù\u0001–VNß`\vRM\rÇÆÖú”ú¢ÏC,ï’");
            _dataServiceMock.Setup(t => t.GetPassword(It.IsAny<string>())).Returns("\u001aòÒÀ?º”Õ»uÜ'©)\u0014âÏ˜R…ò•G<MïÄ\u008dûžMá‘7µ\u001d\u0014+\u0012»NƒÿÎ\u0001mN\n\u001e\u0018\t»3z\u0010é•<Áx¿ e4Gx;3Å}±“„üsa(äÞbz\u0010ñ!)À²?u¿nÙã¹kÚ \u0017Dœ\u001f¾…@tôKê­\u001co\nY²RÍ\u009d÷3’È\u0002‹~¢\u0090c\u0018");
            _dataServiceMock.Setup(t => t.GetUserByEmail(It.IsAny<string>())).Returns(_testUser);

            //Act
            bool actual = _sut.AttemptLogin(_testUser.Email, "Test1234!");

            //Assert
            Assert.True(actual);

        }

        [Fact]
        public void TestGenerateHashSalt()
        {
            //Arrange

            //Act
            string salt1 = _sut.GenerateHashSalt();
            string salt2 = _sut.GenerateHashSalt();

            //Assert
            Assert.NotEqual(salt1, salt2);

        }

        [Fact]
        public void TestHasher()
        {
            //Arrange
            string expected = "\u001aòÒÀ?º”Õ»uÜ'©)\u0014âÏ˜R…ò•G<MïÄ\u008dûžMá‘7µ\u001d\u0014+\u0012»NƒÿÎ\u0001mN\n\u001e\u0018\t»3z\u0010é•<Áx¿ e4Gx;3Å}±“„üsa(äÞbz\u0010ñ!)À²?u¿nÙã¹kÚ \u0017Dœ\u001f¾…@tôKê­\u001co\nY²RÍ\u009d÷3’È\u0002‹~¢\u0090c\u0018";
            string saltString = "qµQ\u001bæ¿UZƒBÚ\u0081S°Sðôrw‚Y©\fƒ\u0011\u000e€kùÉouÀŒ0qSÀ|¨69ãœí`\u0011¿aNÃ³²½\v\u008dUÁ€‘—7ká\u0081»Ùóä\tØ\f_ ‰\u0003ž\t<¢›¨e\u009d~?}ý¯7{ïë²\u0081”r‡Ùx\u001dlK¼5Ù\u0001–VNß`\vRM\rÇÆÖú”ú¢ÏC,ï’";
            
            //Act
            string actual = _sut.Hasher(saltString, "Test1234!");
            
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCheckEmailIsUnique()
        {
            //Arrange
            _dataServiceMock.Setup(t => t.CheckEmailIsUnique(It.IsAny<string>())).Returns(0);

            //Act
            bool actual = _sut.CheckEmailIsUnique(_testUser.Email);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void TestExpressionValidatorEmail()
        {
            //Arrange
            string validationString = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";

            //Act
            bool actual = _sut.ExpressionValidator(_testUser.Email, validationString);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void TestExpressionValidatorPassword()
        {
            //Arrange
            string validationString = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

            //Act
            bool actual = _sut.ExpressionValidator("Test1234!", validationString);

            //Assert
            Assert.True(actual);
        }


    }
}
