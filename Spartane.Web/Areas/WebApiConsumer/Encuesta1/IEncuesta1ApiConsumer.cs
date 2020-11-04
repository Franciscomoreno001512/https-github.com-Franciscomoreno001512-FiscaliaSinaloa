using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Encuesta1
{
    public interface IEncuesta1ApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Encuesta1.Encuesta1>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Encuesta1.Encuesta1>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Encuesta1.Encuesta1> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Encuesta1.Encuesta1PagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Encuesta1Information, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Encuesta1.Encuesta1 entity, Spartane.Core.Domain.User.GlobalData Encuesta1Information, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Encuesta1.Encuesta1 entity, Spartane.Core.Domain.User.GlobalData Encuesta1Information, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Encuesta1.Encuesta1>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Encuesta1.Encuesta1>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Encuesta1.Encuesta1>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Encuesta1.Encuesta1PagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Encuesta1.Encuesta1>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Encuesta1.Encuesta1_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Encuesta1.Encuesta1_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

