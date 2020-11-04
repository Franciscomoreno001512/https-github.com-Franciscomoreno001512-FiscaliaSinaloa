using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Documento_Extraviado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Documento_Extraviado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Documento_ExtraviadoService : IDocumento_ExtraviadoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> _Documento_ExtraviadoRepository;
        #endregion

        #region Ctor
        public Documento_ExtraviadoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> Documento_ExtraviadoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Documento_ExtraviadoRepository = Documento_ExtraviadoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> SelAll(bool ConRelaciones)
        {
            return this._Documento_ExtraviadoRepository.Table.ToList();
        }

        public IList<Core.Domain.Documento_Extraviado.Documento_Extraviado> SelAllComplete(bool ConRelaciones)
        {
            return this._Documento_ExtraviadoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Documento_ExtraviadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Documento_ExtraviadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Documento_ExtraviadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Documento_Extraviado.Documento_ExtraviadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Documento_ExtraviadoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Documento_ExtraviadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Documento_ExtraviadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado entity, Spartane.Core.Domain.User.GlobalData Documento_ExtraviadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado entity, Spartane.Core.Domain.User.GlobalData Documento_ExtraviadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

