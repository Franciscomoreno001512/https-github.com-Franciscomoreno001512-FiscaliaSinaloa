using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Asignacion_de_Agente;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Asignacion_de_Agente
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Asignacion_de_AgenteService : IAsignacion_de_AgenteService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente> _Asignacion_de_AgenteRepository;
        #endregion

        #region Ctor
        public Asignacion_de_AgenteService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente> Asignacion_de_AgenteRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Asignacion_de_AgenteRepository = Asignacion_de_AgenteRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente> SelAll(bool ConRelaciones)
        {
            return this._Asignacion_de_AgenteRepository.Table.ToList();
        }

        public IList<Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente> SelAllComplete(bool ConRelaciones)
        {
            return this._Asignacion_de_AgenteRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Asignacion_de_AgenteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Asignacion_de_AgenteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Asignacion_de_AgenteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_AgentePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Asignacion_de_AgentePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Asignacion_de_AgenteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Asignacion_de_AgenteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente entity, Spartane.Core.Domain.User.GlobalData Asignacion_de_AgenteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente entity, Spartane.Core.Domain.User.GlobalData Asignacion_de_AgenteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

