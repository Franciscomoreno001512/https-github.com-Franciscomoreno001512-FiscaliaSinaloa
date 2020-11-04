using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Director_de_Agencia
{
    public interface IDirector_de_AgenciaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Director_de_Agencia.Director_de_AgenciaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Director_de_AgenciaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia entity, Spartane.Core.Domain.User.GlobalData Director_de_AgenciaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia entity, Spartane.Core.Domain.User.GlobalData Director_de_AgenciaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Director_de_Agencia.Director_de_AgenciaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

