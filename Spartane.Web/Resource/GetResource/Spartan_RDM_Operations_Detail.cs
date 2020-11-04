using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Spartan_RDM_Operations_DetailResources
    {
        //private static IResourceProvider resourceProviderSpartan_RDM_Operations_Detail = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Spartan_RDM_Operations_DetailResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSpartan_RDM_Operations_Detail = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Spartan_RDM_Operations_DetailResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSpartan_RDM_Operations_Detail = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Spartan_RDM_Operations_DetailResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Spartan_RDM_Operations_Detail</summary>
        public static string Spartan_RDM_Operations_Detail
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Operations_Detail.GetResource("Spartan_RDM_Operations_Detail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>DetailId</summary>
        public static string DetailId
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Operations_Detail.GetResource("DetailId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Object_Name</summary>
        public static string Object_Name
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Operations_Detail.GetResource("Object_Name", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Object_Label</summary>
        public static string Object_Label
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Operations_Detail.GetResource("Object_Label", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Order_Shown</summary>
        public static string Order_Shown
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Operations_Detail.GetResource("Order_Shown", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Count_Query</summary>
        public static string Count_Query
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Operations_Detail.GetResource("Count_Query", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Query_Data</summary>
        public static string Query_Data
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Operations_Detail.GetResource("Query_Data", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Icono</summary>
        public static string Icono
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Operations_Detail.GetResource("Icono", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderSpartan_RDM_Operations_Detail.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
