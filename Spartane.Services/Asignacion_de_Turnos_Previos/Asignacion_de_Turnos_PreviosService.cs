using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Asignacion_de_Turnos_Previos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Asignacion_de_Turnos_Previos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Asignacion_de_Turnos_PreviosService : IAsignacion_de_Turnos_PreviosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> _Asignacion_de_Turnos_PreviosRepository;
        #endregion

        #region Ctor
        public Asignacion_de_Turnos_PreviosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> Asignacion_de_Turnos_PreviosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Asignacion_de_Turnos_PreviosRepository = Asignacion_de_Turnos_PreviosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> SelAll(bool ConRelaciones)
        {
            return this._Asignacion_de_Turnos_PreviosRepository.Table.ToList();
        }

        public IList<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> SelAllComplete(bool ConRelaciones)
        {
            return this._Asignacion_de_Turnos_PreviosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Asignacion_de_Turnos_PreviosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Asignacion_de_Turnos_PreviosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Asignacion_de_Turnos_PreviosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_PreviosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Asignacion_de_Turnos_PreviosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Asignacion_de_Turnos_PreviosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Asignacion_de_Turnos_PreviosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos entity, Spartane.Core.Domain.User.GlobalData Asignacion_de_Turnos_PreviosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos entity, Spartane.Core.Domain.User.GlobalData Asignacion_de_Turnos_PreviosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

