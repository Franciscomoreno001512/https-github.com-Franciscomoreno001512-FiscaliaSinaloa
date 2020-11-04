using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Violencia_de_Genero
{
    public interface IViolencia_de_GeneroApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_Genero>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_Genero>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_Genero> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_GeneroPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Violencia_de_GeneroInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_Genero entity, Spartane.Core.Domain.User.GlobalData Violencia_de_GeneroInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_Genero entity, Spartane.Core.Domain.User.GlobalData Violencia_de_GeneroInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_Genero>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_Genero>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_Genero>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_GeneroPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_Genero>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_Genero_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_Genero_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

