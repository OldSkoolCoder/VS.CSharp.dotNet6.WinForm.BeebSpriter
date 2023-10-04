using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeebSpriter.Internal
{
    public class UserConfig
    {
        /// <summary>
        /// Write to the user app config with the follwing key and value.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Write(string key, string value)
        {
            try
            {

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection settings = config.AppSettings.Settings;

                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Read the user app config file for keys
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Read(string key)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection settings = config.AppSettings.Settings;

                string ret = String.Empty;

                if (settings[key] != null)
                {
                    ret = settings[key].Value;
                }

                return ret;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return String.Empty;
            }
        }

    }
}
