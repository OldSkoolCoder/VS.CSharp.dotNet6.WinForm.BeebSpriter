﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

namespace BeebSpriter.Internal
{
    public class MyJSON
    {
        public List<string> Paths { get; set; }

        public string fileName = "RecentBeepSpriter.json";

        public MyJSON(List<string> paths=null)
        {
            this.Paths = paths;
        }

        /// <summary>
        /// Save json file as this.fileNamer
        /// </summary>
        public void SaveJson()
        {
            try
            {
                string json = JsonSerializer.Serialize<MyJSON>(this);
                UserConfig config = new();
                config.Write("Paths",json);

                //File.WriteAllText(this.fileName, json);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Load json file (this.fileName) and add it to res pointer.
        /// </summary>
        /// <param name="res"></param>
        public void LoadJson(RecentFilesList res)
        {
            try
            {
                UserConfig config = new();
                var jsonStr = config.Read("Paths");

                if (jsonStr == String.Empty) return;

                MyJSON myJSON = JsonSerializer.Deserialize<MyJSON>(jsonStr);
                
                foreach (string path in myJSON.Paths)
                {
                    res.Add(path);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
