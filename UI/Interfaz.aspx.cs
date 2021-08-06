using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;


namespace UI
{
    public partial class Interfaz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

            
            Negocio.Negocio obj = new Negocio.Negocio();
            foreach(var campo in obj.Listardatos(tbNDoc.Text,int.Parse(seleccion.Value)))
            {
                tbNombre.Text = campo.Nombre1;
                tbApellido.Text = campo.Apellido1;
                tbDireccion.Text = campo.Direccion1;
                tbMail.Text = campo.Email1;
                tbTelefono.Text = campo.Telefono1;
                tbUsuario.Text = campo.NombreUsuario1;
                tbContrasena.Text =Decripter( campo.Password1);
            }

            btnModificar.Enabled = true;
            //  HabilitarInput();
            btnNuevo.Enabled = false;
            ver.Disabled = false;
            tbNDoc.Enabled = false;
            seleccion.Disabled = true;
            inhabilitarInput();


            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            }
            catch
            {
                string msg = "Este documento no esta registrado cree un nuevo suscriptor";
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                   "Advertencia",
                   "alert('" + msg + "');", true);

                btnNuevo.Enabled = true;
                // HabilitarInput();
                tbUsuario.Enabled = true;
                btnModificar.Enabled = false;
                Limpiar2();
            }


        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

            HabilitarInput();

            btnModificar.Enabled = false;
            seleccion.Disabled = true;
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarInput();
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {





        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Enabled == true && tbNombre.Enabled == true)
            {

                Limpiar();
                inhabilitarInput();
                btnModificar.Enabled = false;
                btnNuevo.Enabled = false;
            }
            else if (tbUsuario.Enabled == false && tbNombre.Enabled == true && tbApellido.Enabled == true)
            {
                inhabilitarInput();
                tbNDoc.Enabled = true;

            }

            else if (tbUsuario.Enabled == false && tbNombre.Enabled == false && tbApellido.Enabled == false)
            {
                Limpiar();
                inhabilitarInput();
                tbNDoc.Enabled = true;
                ver.Disabled = true;
                btnAceptar.Enabled = false;
                btnCancelar.Enabled = false;

            }
        }



        public static string Encripter(string password)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(password);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        public static string Decripter(string password)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(password);
            result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }


        private void HabilitarInput()
        {
            tbNombre.Enabled = true;
            tbApellido.Enabled = true;
            tbDireccion.Enabled = true;
            tbMail.Enabled = true;
            tbTelefono.Enabled = true;
            //tbUsuario.Enabled = true;
            tbContrasena.Enabled = true;
            seleccion.Disabled = false;
        }

        private void inhabilitarInput()
        {
            tbNombre.Enabled = false;
            tbApellido.Enabled = false;
            tbDireccion.Enabled = false;
            tbMail.Enabled = false;
            tbTelefono.Enabled = false;
            tbUsuario.Enabled = false;
            tbContrasena.Enabled = false;
            seleccion.Disabled = false;
        }

        private void Limpiar()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbDireccion.Text = "";
            tbMail.Text = "";
            tbTelefono.Text = "";
            tbUsuario.Text = "";
            tbContrasena.Text = "";
            tbNDoc.Text = "";
            ver.Disabled = false;

        }
        private void Limpiar2()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbDireccion.Text = "";
            tbMail.Text = "";
            tbTelefono.Text = "";
            tbUsuario.Text = "";
            tbContrasena.Text = "";
            ver.Disabled = false;

        }
    }
}