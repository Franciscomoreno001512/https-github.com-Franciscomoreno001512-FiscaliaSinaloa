using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Modulo_de_Atencion_Inicial
{
    public interface IModulo_de_Atencion_InicialApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_InicialPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Modulo_de_Atencion_InicialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial entity, Spartane.Core.Domain.User.GlobalData Modulo_de_Atencion_InicialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial entity, Spartane.Core.Domain.User.GlobalData Modulo_de_Atencion_InicialInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_InicialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_del_Caso(Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Caso entity);
		ApiResponse<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Caso> Get_Datos_del_Caso(string Key);

		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Datos_del_Tutor(Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Tutor entity);
		ApiResponse<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Tutor> Get_Datos_del_Tutor(string Key);

		ApiResponse<int> Update_Datos_del_Representante_Legal(Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Representante_Legal entity);
		ApiResponse<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Representante_Legal> Get_Datos_del_Representante_Legal(string Key);

		ApiResponse<int> Update_Datos_de_los_Hechos(Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_los_Hechos entity);
		ApiResponse<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_los_Hechos> Get_Datos_de_los_Hechos(string Key);

		ApiResponse<int> Update_Datos_de_Servicios_de_Apoyo(Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_Apoyo entity);
		ApiResponse<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_Apoyo> Get_Datos_de_Servicios_de_Apoyo(string Key);

		ApiResponse<int> Update_Servicios_de_Apoyo(Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Servicios_de_Apoyo entity);
		ApiResponse<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Servicios_de_Apoyo> Get_Servicios_de_Apoyo(string Key);

		ApiResponse<int> Update_Tipo_de_Compareciente(Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Tipo_de_Compareciente entity);
		ApiResponse<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Tipo_de_Compareciente> Get_Tipo_de_Compareciente(string Key);

		ApiResponse<int> Update_Datos_de_los_Hechos_en_MPO(Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPO entity);
		ApiResponse<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPO> Get_Datos_de_los_Hechos_en_MPO(string Key);


    }
}

