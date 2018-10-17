using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03JohnTheRobot
{
    public class Humanoid
    {
        private readonly Skill _skill;

        public Humanoid()
        {
            _skill = new Skill();
        }

        public Humanoid(Skill skill)
        {
            _skill = skill;
        }

        public string ShowSkill()
        {
            return _skill.ShowSkill();
        }
    }
}
