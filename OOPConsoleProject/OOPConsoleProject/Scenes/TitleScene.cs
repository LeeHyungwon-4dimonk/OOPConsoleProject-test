using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class TitleScene : BaseScene
    {   
        public override void Render()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("*     레전드 RPG     *");
            Console.WriteLine("**********************");
            Console.WriteLine();
            Console.WriteLine("계속 하려면 아무 키나 누르세요...");
        }

        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            Game.ChangeScene("Test01");
        }

        
    }
}
