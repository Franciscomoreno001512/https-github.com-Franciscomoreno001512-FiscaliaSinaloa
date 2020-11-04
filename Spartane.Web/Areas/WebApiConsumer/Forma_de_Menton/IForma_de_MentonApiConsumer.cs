using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Forma_de_Menton
{
    public interface IForma_de_MentonApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Forma_de_Menton.Forma_de_MentonPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Forma_de_MentonInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton entity, Spartane.Core.Domain.User.GlobalData Forma_de_MentonInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton entity, Spartane.Core.Domain.User.GlobalData Forma_de_MentonInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Forma_de_Menton.Forma_de_MentonPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

