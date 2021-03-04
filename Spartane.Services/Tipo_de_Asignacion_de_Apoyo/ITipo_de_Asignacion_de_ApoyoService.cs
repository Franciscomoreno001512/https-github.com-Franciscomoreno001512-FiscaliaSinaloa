﻿using System;
using Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Asignacion_de_Apoyo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_Asignacion_de_ApoyoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo.Tipo_de_Asignacion_de_Apoyo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo.Tipo_de_Asignacion_de_Apoyo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo.Tipo_de_Asignacion_de_Apoyo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo.Tipo_de_Asignacion_de_Apoyo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo.Tipo_de_Asignacion_de_Apoyo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo.Tipo_de_Asignacion_de_Apoyo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo.Tipo_de_Asignacion_de_Apoyo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo.Tipo_de_Asignacion_de_Apoyo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo.Tipo_de_Asignacion_de_ApoyoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo.Tipo_de_Asignacion_de_Apoyo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
