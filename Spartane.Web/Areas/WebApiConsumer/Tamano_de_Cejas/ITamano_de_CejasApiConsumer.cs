using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Tamano_de_Cejas
{
    public interface ITamano_de_CejasApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_CejasPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Tamano_de_CejasInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas entity, Spartane.Core.Domain.User.GlobalData Tamano_de_CejasInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas entity, Spartane.Core.Domain.User.GlobalData Tamano_de_CejasInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_CejasPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

