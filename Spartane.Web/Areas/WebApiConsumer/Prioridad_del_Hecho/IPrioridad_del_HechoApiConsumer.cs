using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Prioridad_del_Hecho
{
    public interface IPrioridad_del_HechoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_HechoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Prioridad_del_HechoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho entity, Spartane.Core.Domain.User.GlobalData Prioridad_del_HechoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho entity, Spartane.Core.Domain.User.GlobalData Prioridad_del_HechoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_HechoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

