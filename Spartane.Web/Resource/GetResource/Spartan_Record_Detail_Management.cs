using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Spartan_Record_Detail_ManagementResources
    {
        //private static IResourceProvider resourceProviderSpartan_Record_Detail_Management = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Spartan_Record_Detail_ManagementResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSpartan_Record_Detail_Management = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Spartan_Record_Detail_ManagementResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSpartan_Record_Detail_Management = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Spartan_Record_Detail_ManagementResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Spartan_Record_Detail_Management</summary>
        public static string Spartan_Record_Detail_Management
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Spartan_Record_Detail_Management", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Process_Id</summary>
        public static string Process_Id
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Process_Id", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Register_Date</summary>
        public static string Register_Date
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Register_Date", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Register_Hour</summary>
        public static string Register_Hour
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Register_Hour", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Register_User</summary>
        public static string Register_User
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Register_User", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Description</summary>
        public static string Description
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Object</summary>
        public static string Object
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Object", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Reference_Label</summary>
        public static string Reference_Label
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Reference_Label", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Reference_Field</summary>
        public static string Reference_Field
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Reference_Field", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Filters</summary>
        public static string Filters
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Filters", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Search_Result</summary>
        public static string Search_Result
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Search_Result", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Search_Result_Query</summary>
        public static string Search_Result_Query
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Search_Result_Query", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Image_Field</summary>
        public static string Image_Field
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Image_Field", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Data_Detail</summary>
        public static string Data_Detail
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Data_Detail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Query_Data_Detail</summary>
        public static string Query_Data_Detail
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Query_Data_Detail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Detail</summary>
        public static string Detail
        {
            get
            {
                SetPath();
                return resourceProviderSpartan_Record_Detail_Management.GetResource("Detail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderSpartan_Record_Detail_Management.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Búsqueda</summary>	public static string TabBusqueda 	{		get		{			SetPath();  			return resourceProviderSpartan_Record_Detail_Management.GetResource("TabBusqueda", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Información General</summary>	public static string TabInformacion_General 	{		get		{			SetPath();  			return resourceProviderSpartan_Record_Detail_Management.GetResource("TabInformacion_General", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Operaciones</summary>	public static string TabOperaciones 	{		get		{			SetPath();  			return resourceProviderSpartan_Record_Detail_Management.GetResource("TabOperaciones", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
