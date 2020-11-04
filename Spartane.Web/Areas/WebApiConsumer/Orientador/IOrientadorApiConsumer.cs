using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Orientador
{
    public interface IOrientadorApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Orientador.Orientador>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Orientador.Orientador>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Orientador.Orientador> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Orientador.OrientadorPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData OrientadorInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Orientador.Orientador entity, Spartane.Core.Domain.User.GlobalData OrientadorInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Orientador.Orientador entity, Spartane.Core.Domain.User.GlobalData OrientadorInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Orientador.Orientador>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Orientador.Orientador>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Orientador.Orientador>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Orientador.OrientadorPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Orientador.Orientador>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_de_Servicios_de_Apoyo(Spartane.Core.Domain.Orientador.Orientador_Datos_de_Servicios_de_Apoyo entity);
		ApiResponse<Spartane.Core.Domain.Orientador.Orientador_Datos_de_Servicios_de_Apoyo> Get_Datos_de_Servicios_de_Apoyo(string Key);

		ApiResponse<int> Update_Datos_del_Imputado(Spartane.Core.Domain.Orientador.Orientador_Datos_del_Imputado entity);
		ApiResponse<Spartane.Core.Domain.Orientador.Orientador_Datos_del_Imputado> Get_Datos_del_Imputado(string Key);

		ApiResponse<int> Update_Datos_de_los_Hechos(Spartane.Core.Domain.Orientador.Orientador_Datos_de_los_Hechos entity);
		ApiResponse<Spartane.Core.Domain.Orientador.Orientador_Datos_de_los_Hechos> Get_Datos_de_los_Hechos(string Key);

		ApiResponse<int> Update_Datos_del_Delito(Spartane.Core.Domain.Orientador.Orientador_Datos_del_Delito entity);
		ApiResponse<Spartane.Core.Domain.Orientador.Orientador_Datos_del_Delito> Get_Datos_del_Delito(string Key);

		ApiResponse<int> Update_Datos_de_Robo_de_Vehiculo(Spartane.Core.Domain.Orientador.Orientador_Datos_de_Robo_de_Vehiculo entity);
		ApiResponse<Spartane.Core.Domain.Orientador.Orientador_Datos_de_Robo_de_Vehiculo> Get_Datos_de_Robo_de_Vehiculo(string Key);

		ApiResponse<int> Update_Datos_de_Levantamiento_de_Cadaver(Spartane.Core.Domain.Orientador.Orientador_Datos_de_Levantamiento_de_Cadaver entity);
		ApiResponse<Spartane.Core.Domain.Orientador.Orientador_Datos_de_Levantamiento_de_Cadaver> Get_Datos_de_Levantamiento_de_Cadaver(string Key);

		ApiResponse<int> Update_Imputado(Spartane.Core.Domain.Orientador.Orientador_Imputado entity);
		ApiResponse<Spartane.Core.Domain.Orientador.Orientador_Imputado> Get_Imputado(string Key);


    }
}

