using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Juzgado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Juzgado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class JuzgadoService : IJuzgadoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Juzgado.Juzgado> _JuzgadoRepository;
        #endregion

        #region Ctor
        public JuzgadoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Juzgado.Juzgado> JuzgadoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._JuzgadoRepository = JuzgadoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Juzgado.Juzgado> SelAll(bool ConRelaciones)
        {
            return this._JuzgadoRepository.Table.ToList();
        }

        public IList<Core.Domain.Juzgado.Juzgado> SelAllComplete(bool ConRelaciones)
        {
            return this._JuzgadoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Juzgado.Juzgado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._JuzgadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Juzgado.Juzgado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._JuzgadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Juzgado.Juzgado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._JuzgadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Juzgado.JuzgadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            JuzgadoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Juzgado.Juzgado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._JuzgadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Juzgado.Juzgado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Juzgado.Juzgado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData JuzgadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Juzgado.Juzgado entity, Spartane.Core.Domain.User.GlobalData JuzgadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Juzgado.Juzgado entity, Spartane.Core.Domain.User.GlobalData JuzgadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

