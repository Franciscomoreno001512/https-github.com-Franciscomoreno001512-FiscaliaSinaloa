using System;
using Spartane.Core.Domain.Bitacora_de_Usuarios;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Bitacora_de_Usuarios
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IBitacora_de_UsuariosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_UsuariosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
