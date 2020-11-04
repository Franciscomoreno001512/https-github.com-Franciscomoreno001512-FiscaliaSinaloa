using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Spartan_Record_Detail_Management
{
    public interface ISpartan_Record_Detail_ManagementApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_ManagementPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Spartan_Record_Detail_ManagementInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management entity, Spartane.Core.Domain.User.GlobalData Spartan_Record_Detail_ManagementInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management entity, Spartane.Core.Domain.User.GlobalData Spartan_Record_Detail_ManagementInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_ManagementPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Busqueda(Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Busqueda entity);
		ApiResponse<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Busqueda> Get_Busqueda(string Key);

		ApiResponse<int> Update_Informacion_General(Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Informacion_General entity);
		ApiResponse<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Informacion_General> Get_Informacion_General(string Key);

		ApiResponse<int> Update_Operaciones(Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Operaciones entity);
		ApiResponse<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Operaciones> Get_Operaciones(string Key);


    }
}

