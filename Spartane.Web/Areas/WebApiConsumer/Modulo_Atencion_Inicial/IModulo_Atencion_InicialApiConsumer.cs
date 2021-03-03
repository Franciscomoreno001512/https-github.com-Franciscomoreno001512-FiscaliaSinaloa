using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial
{
    public interface IModulo_Atencion_InicialApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_InicialPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Modulo_Atencion_InicialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial entity, Spartane.Core.Domain.User.GlobalData Modulo_Atencion_InicialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial entity, Spartane.Core.Domain.User.GlobalData Modulo_Atencion_InicialInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_InicialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_del_Caso(Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_del_Caso entity);
		ApiResponse<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_del_Caso> Get_Datos_del_Caso(string Key);

		ApiResponse<int> Update_Informacion_de_Turno(Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Informacion_de_Turno entity);
		ApiResponse<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Informacion_de_Turno> Get_Informacion_de_Turno(string Key);

		ApiResponse<int> Update_Datos_de_los_Hechos_en_MPO(Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPO entity);
		ApiResponse<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPO> Get_Datos_de_los_Hechos_en_MPO(string Key);

		ApiResponse<int> Update_Bitacora_de_Coincidencias(Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Bitacora_de_Coincidencias entity);
		ApiResponse<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Bitacora_de_Coincidencias> Get_Bitacora_de_Coincidencias(string Key);

		ApiResponse<int> Update_Cierre(Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Cierre entity);
		ApiResponse<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Cierre> Get_Cierre(string Key);

		ApiResponse<int> Update_Historial_de_movimientos(Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Historial_de_movimientos entity);
		ApiResponse<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Historial_de_movimientos> Get_Historial_de_movimientos(string Key);


    }
}

