using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MB_Accounting
{
    public class VerticalTabControl : TabControl
    {
        private ColorTheme colorTheme;
        private PrivateFontCollection pfc;
        private Font Montserrat;
        public ColorTheme ColorTheme { set { this.colorTheme = value; } }
        // Constructor

        public VerticalTabControl()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(44, 136);
            Alignment = TabAlignment.Left;
            SelectedIndex = 0;
            this.colorTheme = ColorTheme.Light;
            pfc = new PrivateFontCollection();
            this.InitMontserratMediumFont();
            Montserrat = new Font(pfc.Families[0], 18);
        }

        private void InitMontserratMediumFont()
        {
            int fontLength = Properties.Resources.Montserrat_Medium.Length;
            byte[] fontData = Properties.Resources.Montserrat_Medium;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontData, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap b = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(b);
            if (!DesignMode)
                SelectedTab.BackColor = SystemColors.Control;
            g.Clear(SystemColors.Control);


            // Rest of menu
            if (this.colorTheme == ColorTheme.Light)
            {
                g.FillRectangle(new SolidBrush(ColorPalette.White),
                    new Rectangle(0, 0, ItemSize.Height + 4, Height));

                // Rest of menu side line
                g.DrawLine(new Pen(ColorPalette.DarkGrey), new Point(ItemSize.Height + 3, 0),
                    new Point(ItemSize.Height + 3, 999));
                g.DrawLine(new Pen(ColorPalette.DarkGrey), new Point(0, Size.Height - 1),
                    new Point(Width + 3, Size.Height - 1));
            }
            else
            {
                g.FillRectangle(new SolidBrush(ColorPalette.DarkBlue),
                    new Rectangle(0, 0, ItemSize.Height + 4, Height));

                // Rest of menu side line
                g.DrawLine(new Pen(ColorPalette.White), new Point(ItemSize.Height + 3, 0),
                    new Point(ItemSize.Height + 3, 999));
                g.DrawLine(new Pen(ColorPalette.White), new Point(0, Size.Height - 1),
                    new Point(Width + 3, Size.Height - 1));
            }



            for (int i = 0; i <= TabCount - 1; i++)
            {
                if (i == SelectedIndex)
                {
                    Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2),
                        new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));
                    ColorBlend myBlend = new ColorBlend();
                    // Selected tab background color
                    if (this.colorTheme == ColorTheme.Light)
                    {
                        myBlend.Colors = new Color[] { Color.FromArgb(245, 245, 245), Color.FromArgb(245, 245, 245), Color.FromArgb(245, 245, 245) };
                    }
                    else
                    {
                        myBlend.Colors = new Color[] { Color.FromArgb(250, ColorPalette.DarkBlue), Color.FromArgb(250, ColorPalette.DarkBlue), Color.FromArgb(250, ColorPalette.DarkBlue) };
                    }
                    myBlend.Positions = new float[] { 0f, 0.5f, 1f };
                    LinearGradientBrush lgBrush = new LinearGradientBrush(x2, Color.Black, Color.Black, 90f);
                    lgBrush.InterpolationColors = myBlend;
                    g.FillRectangle(lgBrush, x2);
                    // Top and bottom border of selected tab
                    if (this.colorTheme == ColorTheme.Light)
                    {
                        g.DrawRectangle(new Pen(ColorPalette.DarkGrey), x2);
                    }
                    else
                    {
                        g.DrawRectangle(new Pen(ColorPalette.White), x2);
                    }

                    g.SmoothingMode = SmoothingMode.HighQuality;
                    Point[] p =
                    {
                        new Point(ItemSize.Height - 3, GetTabRect(i).Location.Y + 20),
                        new Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 14),
                        new Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 27)
                    };
                    g.FillPolygon(SystemBrushes.Control, p);
                    // Side triangle
                    if (this.colorTheme == ColorTheme.Light)
                    {
                        g.DrawPolygon(new Pen(ColorPalette.DarkGrey), p);
                    }
                    else
                    {
                        g.DrawPolygon(new Pen(ColorPalette.White), p);
                    }

                    if (ImageList != null)
                    {
                        try
                        {
                            if (this.colorTheme == ColorTheme.Light)
                            {
                                if (i == 0)
                                {
                                    // First tab logo
                                    g.DrawImage((Image)(new Bitmap(MB_Accounting.Properties.Resources.MB_Accounting_Logo, new Size(220, 115))),
                                        new Point(x2.Location.X + 20, x2.Location.Y + 10));
                                }
                                else if (i == TabCount - 1)
                                {
                                    // Color mode
                                    g.DrawImage((Image)(new Bitmap(MB_Accounting.Properties.Resources.moon, new Size(66, 66))),
                                        new Point(x2.Location.X + 90, x2.Location.Y + 40));
                                }
                                else
                                {
                                    // Picture placement
                                    g.DrawImage(ImageList.Images[TabPages[i].ImageIndex],
                                        new Point(x2.Location.X + 5, x2.Location.Y + 45));
                                }
                                // Selected tab text
                                g.DrawString("  " + TabPages[i].Text, Montserrat, new SolidBrush(ColorPalette.Pink), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    // First tab logo
                                    g.DrawImage((Image)(new Bitmap(MB_Accounting.Properties.Resources.MB_Accounting_Logo_Yellow, new Size(220, 115))),
                                        new Point(x2.Location.X + 20, x2.Location.Y + 10));
                                }
                                else if (i == TabCount - 1)
                                {
                                    // Color mode
                                    g.DrawImage((Image)(new Bitmap(MB_Accounting.Properties.Resources.sun, new Size(66, 66))),
                                        new Point(x2.Location.X + 90, x2.Location.Y + 40));
                                }
                                else
                                {
                                    // Picture placement
                                    g.DrawImage(ImageList.Images[TabPages[i].ImageIndex],
                                        new Point(x2.Location.X + 5, x2.Location.Y + 45));
                                }
                                // Selected tab text
                                g.DrawString("  " + TabPages[i].Text, Montserrat, new SolidBrush(ColorPalette.Yellow), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                        }
                        catch (Exception)
                        {
                            // Selected tab text
                            if (this.colorTheme == ColorTheme.Light)
                            {
                                g.DrawString(TabPages[i].Text, Montserrat,
                                    new SolidBrush(ColorPalette.Pink), x2, new StringFormat
                                    {
                                        LineAlignment = StringAlignment.Center,
                                        Alignment = StringAlignment.Center
                                    });
                            }
                            else
                            {
                                g.DrawString(TabPages[i].Text, Montserrat,
                                   new SolidBrush(ColorPalette.Yellow), x2, new StringFormat
                                   {
                                       LineAlignment = StringAlignment.Center,
                                       Alignment = StringAlignment.Center
                                   });
                            }
                        }
                    }
                    else
                    {
                        // Selected tab text
                        if (this.colorTheme == ColorTheme.Light)
                        {
                            g.DrawString(TabPages[i].Text, Montserrat,
                                new SolidBrush(ColorPalette.Pink), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                        }
                        else
                        {
                            g.DrawString(TabPages[i].Text, Montserrat,
                                new SolidBrush(ColorPalette.Yellow), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                        }
                    }

                    // ????
                    g.DrawLine(new Pen(Color.FromArgb(200, 200, 250)), new Point(x2.Location.X - 1, x2.Location.Y - 1),
                        new Point(x2.Location.X, x2.Location.Y));
                    g.DrawLine(new Pen(Color.FromArgb(200, 200, 250)), new Point(x2.Location.X - 1, x2.Bottom - 1),
                        new Point(x2.Location.X, x2.Bottom));
                }
                else
                {
                    Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2),
                        new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));
                    if (this.colorTheme == ColorTheme.Light)
                    {
                        // Back color
                        g.FillRectangle(new SolidBrush(ColorPalette.White), x2);
                        // Side line
                        g.DrawLine(new Pen(ColorPalette.DarkGrey), new Point(x2.Right, x2.Top),
                            new Point(x2.Right, x2.Bottom));
                    }
                    else
                    {
                        // Back color
                        g.FillRectangle(new SolidBrush(ColorPalette.DarkBlue), x2);
                        // Side line
                        g.DrawLine(new Pen(ColorPalette.White), new Point(x2.Right, x2.Top),
                            new Point(x2.Right, x2.Bottom));
                    }
                    if (ImageList != null)
                    {
                        try
                        {
                            if (this.colorTheme == ColorTheme.Light)
                            {
                                if (i == 0)
                                {
                                    // First tab logo
                                    g.DrawImage((Image)(new Bitmap(MB_Accounting.Properties.Resources.MB_Accounting_Logo, new Size(220, 115))),
                                        new Point(x2.Location.X + 20, x2.Location.Y + 10));
                                }
                                else if (i == TabCount - 1)
                                {
                                    // Color mode
                                    g.DrawImage((Image)(new Bitmap(MB_Accounting.Properties.Resources.moon, new Size(66, 66))),
                                        new Point(x2.Location.X + 90, x2.Location.Y + 40));
                                }
                                else
                                {
                                    // Picture placement
                                    g.DrawImage(ImageList.Images[TabPages[i].ImageIndex],
                                        new Point(x2.Location.X + 5, x2.Location.Y + 45));
                                }
                                // Tab text
                                g.DrawString("  " + TabPages[i].Text, Montserrat, new SolidBrush(ColorPalette.Pink), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    // First tab logo
                                    g.DrawImage((Image)(new Bitmap(MB_Accounting.Properties.Resources.MB_Accounting_Logo_Yellow, new Size(220, 115))),
                                        new Point(x2.Location.X + 20, x2.Location.Y + 10));
                                }
                                else if (i == TabCount - 1)
                                {
                                    // Color mode
                                    g.DrawImage((Image)(new Bitmap(MB_Accounting.Properties.Resources.sun, new Size(66, 66))),
                                        new Point(x2.Location.X + 90, x2.Location.Y + 40));
                                }
                                else
                                {
                                    // Picture placement
                                    g.DrawImage(ImageList.Images[TabPages[i].ImageIndex],
                                        new Point(x2.Location.X + 5, x2.Location.Y + 45));
                                }
                                // Tab text
                                g.DrawString("  " + TabPages[i].Text, Montserrat, new SolidBrush(ColorPalette.Yellow), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                        }
                        catch (Exception)
                        {
                            if (this.colorTheme == ColorTheme.Light)
                            {
                                // Tab text
                                g.DrawString(TabPages[i].Text, Montserrat, new SolidBrush(ColorPalette.Pink), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                            else
                            {
                                // Tab text
                                g.DrawString(TabPages[i].Text, Montserrat, new SolidBrush(ColorPalette.Yellow), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                        }
                    }
                    else
                    {
                        if (this.colorTheme == ColorTheme.Light)
                        {
                            // Tab text
                            g.DrawString(TabPages[i].Text, Montserrat, new SolidBrush(ColorPalette.Pink), x2, new StringFormat
                            {
                                LineAlignment = StringAlignment.Center,
                                Alignment = StringAlignment.Center
                            });
                        }
                        else
                        {
                            // Tab text
                            g.DrawString(TabPages[i].Text, Montserrat, new SolidBrush(ColorPalette.Yellow), x2, new StringFormat
                            {
                                LineAlignment = StringAlignment.Center,
                                Alignment = StringAlignment.Center
                            });
                        }
                    }
                }
            }

            e.Graphics.DrawImage(b, new Point(0, 0));
            g.Dispose();
            b.Dispose();
        }
    }
}
