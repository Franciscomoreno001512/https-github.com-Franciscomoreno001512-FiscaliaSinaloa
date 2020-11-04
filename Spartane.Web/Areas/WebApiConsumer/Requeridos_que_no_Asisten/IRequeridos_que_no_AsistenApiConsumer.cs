using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Requeridos_que_no_Asisten
{
    public interface IRequeridos_que_no_AsistenApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_AsistenPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Requeridos_que_no_AsistenInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten entity, Spartane.Core.Domain.User.GlobalData Requeridos_que_no_AsistenInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten entity, Spartane.Core.Domain.User.GlobalData Requeridos_que_no_AsistenInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_AsistenPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

