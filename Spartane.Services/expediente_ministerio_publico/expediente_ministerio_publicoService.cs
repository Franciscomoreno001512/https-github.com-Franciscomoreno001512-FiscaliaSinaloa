using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.expediente_ministerio_publico;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.expediente_ministerio_publico
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class expediente_ministerio_publicoService : Iexpediente_ministerio_publicoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> _expediente_ministerio_publicoRepository;
        #endregion

        #region Ctor
        public expediente_ministerio_publicoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> expediente_ministerio_publicoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._expediente_ministerio_publicoRepository = expediente_ministerio_publicoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> SelAll(bool ConRelaciones)
        {
            return this._expediente_ministerio_publicoRepository.Table.ToList();
        }

        public IList<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> SelAllComplete(bool ConRelaciones)
        {
            return this._expediente_ministerio_publicoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._expediente_ministerio_publicoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._expediente_ministerio_publicoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._expediente_ministerio_publicoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publicoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            expediente_ministerio_publicoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._expediente_ministerio_publicoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData expediente_ministerio_publicoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico entity, Spartane.Core.Domain.User.GlobalData expediente_ministerio_publicoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico entity, Spartane.Core.Domain.User.GlobalData expediente_ministerio_publicoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

