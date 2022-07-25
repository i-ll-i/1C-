using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Application_Form {

  public class Form_With_Button : Form {


    bool start_button = true;


    public Button button;

    public Form_With_Button() {

      button = new Button();
      button.Size = new Size( 100 , 100 );
      button.Location = new Point( 20 , 20 );
      button.Text = "Первая сторона";

      this.Controls.Add( button );

      button.Click += new EventHandler( Changing_The_Value );

    }

    public void Changing_The_Value( object sender, EventArgs e ) {

      if ( start_button ) {

        start_button = false;
        Changing_The_Button( );

      } else {

        start_button = true;
        Changing_The_Button( );

      }

    }

    public void Changing_The_Button( ) {

      this.Controls.Remove( button );

      if ( start_button ) {

        button = new Button();
        button.Size = new Size( 100 , 100 );
        button.Location = new Point( 20 , 20 );
        button.Text = "Первая сторона";

        this.Controls.Add( button );

        button.Click += new EventHandler( Changing_The_Value );

      } else {

        button = new Button();
        button.Size = new Size( 100 , 100 );
        button.Location = new Point( 20 , 20 );
        button.Text = "Вторая сторона";

        this.Controls.Add( button );

        button.Click += new EventHandler( Changing_The_Value );

      }

    }

    [STAThread]
    static void Main() {

      Application.EnableVisualStyles( );
      Application.Run( new Form_With_Button() );

    }

  }

}