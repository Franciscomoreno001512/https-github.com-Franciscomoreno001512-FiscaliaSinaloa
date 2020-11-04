using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Estatus_de_Expediente_para_Reuniones
{
    public interface IEstatus_de_Expediente_para_ReunionesApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_ReunionesPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Estatus_de_Expediente_para_ReunionesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones entity, Spartane.Core.Domain.User.GlobalData Estatus_de_Expediente_para_ReunionesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones entity, Spartane.Core.Domain.User.GlobalData Estatus_de_Expediente_para_ReunionesInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_ReunionesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

