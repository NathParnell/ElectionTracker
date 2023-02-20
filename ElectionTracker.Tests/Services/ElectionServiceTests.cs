using ElectionTracker.Models;
using ElectionTracker.Services;
using ElectionTracker.Services.Infrastructure;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ElectionTracker.Tests.Services
{
    public class ElectionServiceTests
    {
        private readonly Mock<IUserService> _userServiceMock = new Mock<IUserService>();
        private readonly Mock<IDataService> _dataServiceMock = new Mock<IDataService>();

        private readonly User _testUser = new User(
            "John",
            "Smith",
            "30-38 Dock Street, Leeds",
            "LS10 1JF",
            DateTime.Now,
            "c1040085@my.hallam.ac.uk");


        private readonly List<ElectionGroup> _testElectionGroups = new List<ElectionGroup>()
        {
            new ElectionGroup{ElectionGroupID = "1", Name = "Test Election 1", Description = "Test Election 1 Description", EntryDate = DateTime.Now},
            new ElectionGroup{ElectionGroupID = "UserElectionGroup", Name = "Test Election 2", Description = "Test Election 2 Description", EntryDate = DateTime.Now},
            new ElectionGroup{ElectionGroupID = "3", Name = "Test Election 3", Description = "Test Election 3 Description", EntryDate = DateTime.Now}
        };

        private readonly List<string> _testUserElectionGroupIDs = new List<string>()
        {
            "UserElectionGroup"
        };

        private readonly IElectionService _sut;

        public ElectionServiceTests() 
        {
            _sut = new ElectionService(_userServiceMock.Object, _dataServiceMock.Object);
        }

        [Fact]
        public void TestCreateElectionGroup()
        {
            //Arrange
            _dataServiceMock.Setup(t => t.CreateElectionGroup(It.IsAny<ElectionGroup>()));
            _dataServiceMock.Setup(t => t.CreateElectionGroupMembership(It.IsAny<ElectionGroupMembership>()));
            _userServiceMock.Setup(t => t.CurrentUser).Returns(_testUser);

            //Act
            bool actual = _sut.CreateElectionGroup("Name", "Description");

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void TestGetElectionGroupsUserIsNotAPartOf()
        {
            //Arrange
            _dataServiceMock.Setup(t => t.GetAllElectionGroups()).Returns(_testElectionGroups);
            _dataServiceMock.Setup(t => t.GetUserElectionGroupIDs(It.IsAny<string>())).Returns(_testUserElectionGroupIDs);

            //Act
            List<ElectionGroup> actual = _sut.GetElectionGroupsUserIsNotAPartOf(_testUser);

            //Assert
            Assert.Equal(2, actual.Count);

            foreach (ElectionGroup electionGroup in actual)
            {
                Assert.DoesNotContain("UserElectionGroup", electionGroup.ElectionGroupID);
            }
        }

        [Fact]
        public void TestGetElectionWinner()
        {
            //Arrange
            List<Candidate> candidates = new List<Candidate>()
            {
                new Candidate() {CandidateID = "1"},
                new Candidate() {CandidateID = "2"}
            };

            List<Vote> votesCandidate1 = new List<Vote>()
            {
                new Vote() {VoteID = "1", CandidateID = "1"},
                new Vote() {VoteID = "2", CandidateID = "1"},
                new Vote() {VoteID = "3", CandidateID = "1"},
                new Vote() {VoteID = "4", CandidateID = "1"},
            };

            List<Vote> votesCandidate2 = new List<Vote>()
            {
                new Vote() {VoteID = "5", CandidateID = "1"},
                new Vote() {VoteID = "6", CandidateID = "1"}
            };

            _dataServiceMock.Setup(t => t.GetCandidatesByElectionID(It.IsAny<string>())).Returns(candidates);
            _dataServiceMock.Setup(t => t.GetVotesByCandidateID("1")).Returns(votesCandidate1);
            _dataServiceMock.Setup(t => t.GetVotesByCandidateID("2")).Returns(votesCandidate2);

            //Act
            Candidate actual = _sut.GetElectionWinner(new Election());

            //Assert
            Assert.Equal(candidates[0].CandidateID, actual.CandidateID);

        }

    }
}
