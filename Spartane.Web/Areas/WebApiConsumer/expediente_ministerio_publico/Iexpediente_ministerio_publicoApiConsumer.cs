using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico
{
    public interface Iexpediente_ministerio_publicoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publicoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData expediente_ministerio_publicoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico entity, Spartane.Core.Domain.User.GlobalData expediente_ministerio_publicoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico entity, Spartane.Core.Domain.User.GlobalData expediente_ministerio_publicoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publicoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_del_Caso(Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Datos_del_Caso entity);
		ApiResponse<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Datos_del_Caso> Get_Datos_del_Caso(string Key);

		ApiResponse<int> Update_Hechos(Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Hechos entity);
		ApiResponse<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Hechos> Get_Hechos(string Key);

		ApiResponse<int> Update_Canalizar(Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Canalizar entity);
		ApiResponse<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Canalizar> Get_Canalizar(string Key);

		ApiResponse<int> Update_Datos_del_Acuerdo(Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Datos_del_Acuerdo entity);
		ApiResponse<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Datos_del_Acuerdo> Get_Datos_del_Acuerdo(string Key);

		ApiResponse<int> Update_Cierre_de_Expediente(Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Cierre_de_Expediente entity);
		ApiResponse<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Cierre_de_Expediente> Get_Cierre_de_Expediente(string Key);


    }
}

