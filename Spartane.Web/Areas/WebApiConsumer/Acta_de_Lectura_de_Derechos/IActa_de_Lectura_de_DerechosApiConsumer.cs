using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Acta_de_Lectura_de_Derechos
{
    public interface IActa_de_Lectura_de_DerechosApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_DerechosPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Acta_de_Lectura_de_DerechosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos entity, Spartane.Core.Domain.User.GlobalData Acta_de_Lectura_de_DerechosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos entity, Spartane.Core.Domain.User.GlobalData Acta_de_Lectura_de_DerechosInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_DerechosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

