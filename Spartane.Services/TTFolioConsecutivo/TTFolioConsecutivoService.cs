using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.TTFolioConsecutivo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.TTFolioConsecutivo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class TTFolioConsecutivoService : ITTFolioConsecutivoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> _TTFolioConsecutivoRepository;
        #endregion

        #region Ctor
        public TTFolioConsecutivoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> TTFolioConsecutivoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._TTFolioConsecutivoRepository = TTFolioConsecutivoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> SelAll(bool ConRelaciones)
        {
            return this._TTFolioConsecutivoRepository.Table.ToList();
        }

        public IList<Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> SelAllComplete(bool ConRelaciones)
        {
            return this._TTFolioConsecutivoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._TTFolioConsecutivoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._TTFolioConsecutivoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._TTFolioConsecutivoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            TTFolioConsecutivoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._TTFolioConsecutivoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData TTFolioConsecutivoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo entity, Spartane.Core.Domain.User.GlobalData TTFolioConsecutivoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo entity, Spartane.Core.Domain.User.GlobalData TTFolioConsecutivoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

