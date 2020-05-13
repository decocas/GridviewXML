using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebXml
{
    public partial class WebFormXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            
            
                DataSet da = new DataSet("CONTRYES");
                da.ReadXml(Server.MapPath("~/datos/file.xml"));
                DataTable table = new DataTable("Contry");// crear las columnas
                DataColumn col1 = new DataColumn("Id", typeof(int), "", MappingType.Attribute);
                DataColumn col2 = new DataColumn("Nombre", typeof(string) ,"", MappingType.Attribute); //se dejo vacio para no producir error
                DataColumn col3 = new DataColumn("Poblacion", typeof(int), "", MappingType.Attribute);

                table.Columns.Add(col1); //agregar a la tabla del gridview
                table.Columns.Add(col2);
                table.Columns.Add(col3);
              for(int i = 0; i < 5; i++)
                {
                    DataRow row;
                    row = table.NewRow();        //crear valores en las filas
                    if (i == 0)
                    {
                        row["Id"] = "1"; row["Nombre"] = "China"; row["Poblacion"] = "123132";
                        table.Rows.Add(row); // agregar filas a la taba del gridview

                    }
                    if (i == 1)
                    {
                        row["Id"] = "2"; row["Nombre"] = "Colombia"; row["Poblacion"] = "1232";
                        table.Rows.Add(row); // agregar filas a la taba del gridview

                    }
                    if (i == 2)
                    {
                        row["Id"] = "3"; row["Nombre"] = "USA"; row["Poblacion"] = "32212";
                        table.Rows.Add(row); // agregar filas a la taba del gridview

                    }
                    if (i == 3)
                    {
                        row["Id"] = "4"; row["Nombre"] = "Cuba"; row["Poblacion"] = "132";
                        table.Rows.Add(row); // agregar filas a la taba del gridview

                    }
                    if (i == 4)
                    {
                        row["Id"] = "5"; row["Nombre"] = "URSS"; row["Poblacion"] = "40052";
                        table.Rows.Add(row); // agregar filas a la taba del gridview

                    }

                }

                da.Merge(table);// produjo incompatibilidad entre filas y columnas sin el try cacth
                da.AcceptChanges();
                da.WriteXml(Server.MapPath("~/datos/file.xml"));
                


            }
            catch (Exception ex) { ex.ToString();  }


            /*  d.WriteXml(Server.MapPath("~/datos/file.xml"));
            //da.WriteXml(Server.MapPath("~/datos/file.xml"));
                 DataSet d = new DataSet("CONTRYES");

                DataColumn col1 = new DataColumn("Id", typeof(int), "6", MappingType.Attribute);
                DataColumn col2 = new DataColumn("Nombre", typeof(string), "China", MappingType.Attribute);
                DataColumn col3 = new DataColumn("Population", typeof(int), "12334444", MappingType.Attribute);

                DataTable table = new DataTable();
                table.Columns.Add(col1);
                table.Columns.Add(col2);
                table.Columns.Add(col3);
                d.AcceptChanges();

             */
        }

        protected void Grid1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                DataSet data = new DataSet();
                data.ReadXml(Server.MapPath("~/datos/file.xml"));
                data.Tables[0].Rows[grid1.Rows[e.RowIndex].DataItemIndex].Delete();
                data.WriteXml(Server.MapPath("~/datos/file.xml"));

            }
            catch (Exception ex)
            {
                ex.ToString();
            }


                 /*
            GridViewRow row = grid1.Rows[e.RowIndex];
            String region = row.Cells[1].Text;
           
            // Cancel the delete operation if the country/region is "USA".
            if (region == "USA")
            {
                e.Cancel = true;
                
            }
            */
        }

        protected void Grid1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            /*DataSet data = new DataSet();
            data.ReadXml(Server.MapPath("~/datos/file.xml"));
            grid1.EditIndex = e.RowIndex;
            data.WriteXml(Server.MapPath("~/datos/file.xml"));
            //Esto todavia no funciona
            data.AcceptChanges();*/ 
        }
    }
}