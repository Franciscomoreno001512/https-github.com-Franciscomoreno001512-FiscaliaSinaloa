using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Compareciente;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Compareciente
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class ComparecienteService : IComparecienteService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Compareciente.Compareciente> _ComparecienteRepository;
        #endregion

        #region Ctor
        public ComparecienteService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Compareciente.Compareciente> ComparecienteRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._ComparecienteRepository = ComparecienteRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Compareciente.Compareciente> SelAll(bool ConRelaciones)
        {
            return this._ComparecienteRepository.Table.ToList();
        }

        public IList<Core.Domain.Compareciente.Compareciente> SelAllComplete(bool ConRelaciones)
        {
            return this._ComparecienteRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Compareciente.Compareciente> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ComparecienteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Compareciente.Compareciente> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._ComparecienteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Compareciente.Compareciente> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ComparecienteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Compareciente.ComparecientePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            ComparecientePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Compareciente.Compareciente> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._ComparecienteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Compareciente.Compareciente GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Compareciente.Compareciente result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData ComparecienteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Compareciente.Compareciente entity, Spartane.Core.Domain.User.GlobalData ComparecienteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Compareciente.Compareciente entity, Spartane.Core.Domain.User.GlobalData ComparecienteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

