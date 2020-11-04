using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Orientador;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Orientador
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class OrientadorService : IOrientadorService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Orientador.Orientador> _OrientadorRepository;
        #endregion

        #region Ctor
        public OrientadorService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Orientador.Orientador> OrientadorRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._OrientadorRepository = OrientadorRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Orientador.Orientador> SelAll(bool ConRelaciones)
        {
            return this._OrientadorRepository.Table.ToList();
        }

        public IList<Core.Domain.Orientador.Orientador> SelAllComplete(bool ConRelaciones)
        {
            return this._OrientadorRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Orientador.Orientador> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._OrientadorRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Orientador.Orientador> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._OrientadorRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Orientador.Orientador> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._OrientadorRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Orientador.OrientadorPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            OrientadorPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Orientador.Orientador> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._OrientadorRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Orientador.Orientador GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Orientador.Orientador result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData OrientadorInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Orientador.Orientador entity, Spartane.Core.Domain.User.GlobalData OrientadorInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Orientador.Orientador entity, Spartane.Core.Domain.User.GlobalData OrientadorInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

