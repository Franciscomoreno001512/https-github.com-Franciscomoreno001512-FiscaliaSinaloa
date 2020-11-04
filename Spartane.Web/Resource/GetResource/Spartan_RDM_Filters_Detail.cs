using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Spartan_RDM_Filters_DetailResources
    {
        //private static IResourceProvider resourceProviderSpartan_RDM_Filters_Detail = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Spartan_RDM_Filters_DetailResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSpartan_RDM_Filters_Detail = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Spartan_RDM_Filters_DetailResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSpartan_RDM_Filters_Detail = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Spartan_RDM_Filters_DetailResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Spartan_RDM_Filters_Detail</summary>
        public static string Spartan_RDM_Filters_Detail
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Filters_Detail.GetResource("Spartan_RDM_Filters_Detail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Filters_Detail_Id</summary>
        public static string Filters_Detail_Id
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Filters_Detail.GetResource("Filters_Detail_Id", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Field_Name</summary>
        public static string Field_Name
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Filters_Detail.GetResource("Field_Name", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Field_Label</summary>
        public static string Field_Label
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Filters_Detail.GetResource("Field_Label", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Order_Shown</summary>
        public static string Order_Shown
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Filters_Detail.GetResource("Order_Shown", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Field_Path</summary>
        public static string Field_Path
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Filters_Detail.GetResource("Field_Path", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Physical_Field_Name</summary>
        public static string Physical_Field_Name
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Filters_Detail.GetResource("Physical_Field_Name", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Logical_Field_Name</summary>
        public static string Logical_Field_Name
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_RDM_Filters_Detail.GetResource("Logical_Field_Name", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderSpartan_RDM_Filters_Detail.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
