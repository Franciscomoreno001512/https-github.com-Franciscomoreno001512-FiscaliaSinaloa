using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Documento;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Documento
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class DocumentoService : IDocumentoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Documento.Documento> _DocumentoRepository;
        #endregion

        #region Ctor
        public DocumentoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Documento.Documento> DocumentoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._DocumentoRepository = DocumentoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Documento.Documento> SelAll(bool ConRelaciones)
        {
            return this._DocumentoRepository.Table.ToList();
        }

        public IList<Core.Domain.Documento.Documento> SelAllComplete(bool ConRelaciones)
        {
            return this._DocumentoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Documento.Documento> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._DocumentoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Documento.Documento> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._DocumentoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Documento.Documento> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._DocumentoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Documento.DocumentoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            DocumentoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Documento.Documento> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._DocumentoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Documento.Documento GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Documento.Documento result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData DocumentoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Documento.Documento entity, Spartane.Core.Domain.User.GlobalData DocumentoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Documento.Documento entity, Spartane.Core.Domain.User.GlobalData DocumentoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

