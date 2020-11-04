using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Binario;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Binario
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class BinarioService : IBinarioService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Binario.Binario> _BinarioRepository;
        #endregion

        #region Ctor
        public BinarioService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Binario.Binario> BinarioRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._BinarioRepository = BinarioRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Binario.Binario> SelAll(bool ConRelaciones)
        {
            return this._BinarioRepository.Table.ToList();
        }

        public IList<Core.Domain.Binario.Binario> SelAllComplete(bool ConRelaciones)
        {
            return this._BinarioRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Binario.Binario> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._BinarioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Binario.Binario> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._BinarioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Binario.Binario> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._BinarioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Binario.BinarioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            BinarioPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Binario.Binario> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._BinarioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Binario.Binario GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Binario.Binario result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData BinarioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Binario.Binario entity, Spartane.Core.Domain.User.GlobalData BinarioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Binario.Binario entity, Spartane.Core.Domain.User.GlobalData BinarioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

