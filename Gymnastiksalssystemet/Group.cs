using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet
{
    internal class Group
    {
        public string _Name { get; private set; }
        public IEnumerable<int> _AgeGroup { get; private set; }
        public int _ParticipantCount { get; private set; }
        public int _Id { get; private set; }

        public Group(string name, IEnumerable<int> ageGroup, int participantCount, int id)
        {
            _Name = name;
            _AgeGroup = ageGroup;
            _ParticipantCount = participantCount;
            _Id = id;
        }

        public override string ToString()
        {
            string description = string.Empty;
            description += $"This group's name is: {_Name}\n";
            var tempList = _AgeGroup.ToList();
            description += $"Their age group is: Between {tempList[0]} and {tempList[^1]}\n";
            description += $"The number of participants is: {_ParticipantCount}\n";
            description += $"The group's id is: {_Id}";
            return description;
        }
    }
}
