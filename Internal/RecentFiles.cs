using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BeebSpriter.Internal
{
    public class RecentFilesList
    {
        /// <summary>
        /// Maximum files to remember
        /// </summary>
        private const int MAXCOUNT = 10;

        /// <summary>
        /// Pointer to RecentFilesMenu toolstrip
        /// </summary>
        private readonly ToolStripMenuItem RecentFilesMenu;

        /// <summary>
        /// Get list of files (max 10)
        /// </summary>
        private readonly List<string> SpriteFileList = new();

        public List<String> Files;

        /// <summary>
        /// Action Delegate to OpenSprites(string filename) function
        /// </summary>
        public Action<string> OpenSprites { get; }

        /// <summary>
        /// Update main menu with a list of recent files
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="action"></param>
        public RecentFilesList(ToolStripMenuItem menu, Action<string> action)
        {
            RecentFilesMenu = menu;
            OpenSprites = action;
            UpdateMenu();
        }

        /// <summary>
        /// Generate the files and event clicks for the menu
        /// </summary>
        private void UpdateMenu()
        {
            RecentFilesMenu.DropDownItems.Clear();

            ToolStripMenuItem menuItm = new();

            for (int i = 0; i <= SpriteFileList.Count - 1; i++)
            {
                menuItm = new ToolStripMenuItem
                {
                    Text = (i + 1).ToString() + " " + SpriteFileList[i],
                    Tag = SpriteFileList[i]
                };

                menuItm.Click += MenuItm_Click;
                RecentFilesMenu.DropDownItems.Add(menuItm);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItm_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            OpenSprites(item.Tag.ToString());
        }

        /// <summary>
        /// Add new filename to the list
        /// </summary>
        /// <param name="filename"></param>
        public void Add(string filename)
        {
            while (SpriteFileList.Contains(filename))
            {
                SpriteFileList.Remove(filename);
            }

            SpriteFileList.Insert(0, filename);

            while (SpriteFileList.Count > MAXCOUNT)
            {
                SpriteFileList.RemoveAt(SpriteFileList.Count - 1);
            }

            Files = SpriteFileList;

            UpdateMenu();
        }
    }
}