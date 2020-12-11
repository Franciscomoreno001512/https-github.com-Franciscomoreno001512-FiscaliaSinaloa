using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Compania_de_Seguros;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Compania_de_Seguros
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Compania_de_SegurosService : ICompania_de_SegurosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> _Compania_de_SegurosRepository;
        #endregion

        #region Ctor
        public Compania_de_SegurosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> Compania_de_SegurosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Compania_de_SegurosRepository = Compania_de_SegurosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> SelAll(bool ConRelaciones)
        {
            return this._Compania_de_SegurosRepository.Table.ToList();
        }

        public IList<Core.Domain.Compania_de_Seguros.Compania_de_Seguros> SelAllComplete(bool ConRelaciones)
        {
            return this._Compania_de_SegurosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Compania_de_SegurosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Compania_de_SegurosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Compania_de_SegurosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Compania_de_Seguros.Compania_de_SegurosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Compania_de_SegurosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Compania_de_SegurosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Compania_de_SegurosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros entity, Spartane.Core.Domain.User.GlobalData Compania_de_SegurosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros entity, Spartane.Core.Domain.User.GlobalData Compania_de_SegurosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

