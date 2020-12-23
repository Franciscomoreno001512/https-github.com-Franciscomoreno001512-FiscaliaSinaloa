using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Consulta_de_Mandamientos_Judiciales
{
    public interface IConsulta_de_Mandamientos_JudicialesApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_JudicialesPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Consulta_de_Mandamientos_JudicialesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales entity, Spartane.Core.Domain.User.GlobalData Consulta_de_Mandamientos_JudicialesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales entity, Spartane.Core.Domain.User.GlobalData Consulta_de_Mandamientos_JudicialesInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_JudicialesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

