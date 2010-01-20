using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Skybound.Gecko;

namespace Bootstrap
{
   /// <summary>
   /// 
   /// </summary>
   public partial class MainForm : Form
   {
      /// <summary>
      /// 
      /// </summary>
      public MainForm()
      {
         InitializeComponent();
      }

      private void Form1_Load( object sender, EventArgs e )
      {
         //browser.Navigate( "http://www.cnblogs.com/" );
         browser.Navigate( "http://demo.unigc.com/jppw" );
         browser.CreateWindow += new GeckoCreateWindowEventHandler( browser_CreateWindow );
         //browser.
         //Skybound.Gecko.GeckoPreferences.Save( @"c:\1.txt" );
         browser.Navigated += new GeckoNavigatedEventHandler( browser_Navigated );
         browser.DocumentCompleted += new EventHandler( browser_DocumentCompleted );
      }

      void browser_DocumentCompleted( object sender, EventArgs e )
      {
         GeckoWebBrowser gwb = (GeckoWebBrowser)sender;
         gwb.SaveDocument( @"c:\1.txt" );
      }

      private void browser_Navigated( object sender, GeckoNavigatedEventArgs e )
      {
         //GeckoWebBrowser gwb = (GeckoWebBrowser) sender;
         //MessageBox.Show( gwb.DocumentTitle );
         //gwb.SaveDocument( @"c:\1.txt" );
      }

      private static void browser_CreateWindow( object sender, GeckoCreateWindowEventArgs e )
      {
         //MessageBox.Show( browser.StatusText );
         //PopForm pop = new PopForm( browser.StatusText );
         //pop.ShowDialog( this );
         //MessageBox e.Flags == browser.StatusText
         //throw new Exception( "The method or operation is not implemented." );
         ChromeDialog dialog = new ChromeDialog();
         e.WebBrowser = dialog.WebBrowser;
         dialog.WebBrowser.CreateWindow += new GeckoCreateWindowEventHandler( browser_CreateWindow );
         dialog.WindowState = FormWindowState.Maximized;
         dialog.FormBorderStyle = FormBorderStyle.Sizable;
         dialog.MaximizeBox = true;
         dialog.MinimizeBox = true;
         dialog.WebBrowser.Navigating += new GeckoNavigatingEventHandler( browser_Navigating);
         dialog.Show();
         //dialog.WebBrowser.Window.Document.
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private static void browser_Navigating( object sender, GeckoNavigatingEventArgs e )
      {
         ((GeckoWebBrowser) sender).Text = e.Uri.ToString();
      }
   }
}