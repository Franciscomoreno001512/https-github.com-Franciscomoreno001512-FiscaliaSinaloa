using System;
using Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Jefes_de_Usuarios_del_Sistema
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IJefes_de_Usuarios_del_SistemaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_SistemaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
