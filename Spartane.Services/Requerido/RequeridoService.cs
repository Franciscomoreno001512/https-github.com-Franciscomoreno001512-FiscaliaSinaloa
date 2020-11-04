using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Requerido;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Requerido
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class RequeridoService : IRequeridoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Requerido.Requerido> _RequeridoRepository;
        #endregion

        #region Ctor
        public RequeridoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Requerido.Requerido> RequeridoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._RequeridoRepository = RequeridoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Requerido.Requerido> SelAll(bool ConRelaciones)
        {
            return this._RequeridoRepository.Table.ToList();
        }

        public IList<Core.Domain.Requerido.Requerido> SelAllComplete(bool ConRelaciones)
        {
            return this._RequeridoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Requerido.Requerido> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._RequeridoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Requerido.Requerido> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._RequeridoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Requerido.Requerido> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._RequeridoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Requerido.RequeridoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            RequeridoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Requerido.Requerido> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._RequeridoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Requerido.Requerido GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Requerido.Requerido result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData RequeridoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Requerido.Requerido entity, Spartane.Core.Domain.User.GlobalData RequeridoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Requerido.Requerido entity, Spartane.Core.Domain.User.GlobalData RequeridoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

