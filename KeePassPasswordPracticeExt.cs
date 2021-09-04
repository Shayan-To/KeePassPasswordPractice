using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using KeePass;
using KeePass.Forms;
using KeePass.Plugins;
using KeePass.UI;

using KeePassLib;

namespace KeePassPasswordPractice
{
    public class KeePassPasswordPracticeExt : Plugin
    {
        public const string ShortProductName = "PasswordPractice";

        public override Image SmallIcon
        {
            get
            {
                return Properties.Resources.icon_16x16;
            }
        }

        public override string UpdateUrl
        {
            get
            {
                return "https://github.com/Shayan-To/KeePassPasswordPractice/raw/master/keepass.version";
            }
        }

        public override bool Initialize(IPluginHost host)
        {
            if (host == null)
            {
                return false;
            }

            //Debugger.Launch();

            GlobalWindowManager.WindowAdded += WindowAddedHandler;

            return true;
        }

        public override void Terminate()
        {
            GlobalWindowManager.WindowAdded -= WindowAddedHandler;
        }

        public override ToolStripMenuItem GetMenuItem(PluginMenuType t)
        {
            if (t == PluginMenuType.Entry)
            {
                return CreateToolStripItem(() =>
                {
                    var entries = Program.MainForm.GetSelectedEntries();
                    if (entries != null && entries.Length == 1)
                    {
                        ShowDialog(entries[0]);
                    }
                });
            }
            return null;
        }

        private static void WindowAddedHandler(object sender, GwmWindowEventArgs e)
        {
            var entryForm = e.Form as PwEntryForm;
            if (entryForm != null)
            {
                entryForm.Shown += (s2, e2) =>
                {
                    var m_lvHistory = entryForm.Controls.Find("m_lvHistory", true).FirstOrDefault() as CustomListViewEx;
                    if (m_lvHistory != null)
                    {
                        if (m_lvHistory.ContextMenuStrip == null)
                        {
                            m_lvHistory.ContextMenuStrip = new ContextMenuStrip();
                        }

                        m_lvHistory.ContextMenuStrip.Opening += (o, args) => args.Cancel = m_lvHistory.SelectedIndices.Count != 1;
                        m_lvHistory.ContextMenuStrip.Items.Add(CreateToolStripItem(() =>
                        {
                            var indices = m_lvHistory.SelectedIndices;
                            if (indices.Count != 1)
                            {
                                Debug.Assert(false);
                                return;
                            }

                            var entry = entryForm.EntryRef.History.GetAt((uint) indices[0]);

                            ShowDialog(entry);
                        }));
                    }
                };
            }
        }

        private static ToolStripMenuItem CreateToolStripItem(Action onClick)
        {
            var item = new ToolStripMenuItem
            {
                Text = "Practice password...",
                Image = Properties.Resources.icon_16x16,
                ShortcutKeys = Keys.Control | Keys.OemPipe,
                ShortcutKeyDisplayString = @"Ctrl+\",
            };
            item.Click += (sender, args) => onClick();
            return item;
        }

        private static void ShowDialog(PwEntry entry)
        {
            if (entry == null)
            {
                return;
            }

            using (var dialog = new PasswordPracticeForm(entry.Strings.Get("Password")))
            {
                dialog.ShowDialog();
            }
        }
    }
}
