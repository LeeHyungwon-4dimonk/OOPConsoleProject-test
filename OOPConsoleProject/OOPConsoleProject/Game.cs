using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.Scenes;

namespace OOPConsoleProject
{
    public static class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curscene;

        private static bool gameOver;

        private static Player player;
        public static Player Player { get { return player; } }

        public static void Run()
        {
            Start();

            while(gameOver == false)
            {
                Console.Clear();
                curscene.Render();               
                curscene.Input();
                Console.WriteLine();
                curscene.Update();
                Console.WriteLine();
                curscene.Result();
            }

            End();
        }

        public static void ChangeScene(string sceneName)
        {
            curscene = sceneDic[sceneName];
        }

        /// <summary>
        /// 게임의 초기 설정을 진행
        /// </summary>
        private static void Start()
        {
            Console.CursorVisible = false;
            // 게임 설정
            gameOver = false;            

            player = new Player();

            // 씬 설정
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Field", new FieldScene());

            curscene = sceneDic["Title"];
        }
        /// <summary>
        /// 게임의 마무리 작업 진행
        /// </summary>
        private static void End()
        {

        }
    }
}
