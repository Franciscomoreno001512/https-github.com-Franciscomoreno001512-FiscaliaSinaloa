using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Documentos_Multimedia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Documentos_Multimedia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Documentos_MultimediaService : IDocumentos_MultimediaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> _Documentos_MultimediaRepository;
        #endregion

        #region Ctor
        public Documentos_MultimediaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> Documentos_MultimediaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Documentos_MultimediaRepository = Documentos_MultimediaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> SelAll(bool ConRelaciones)
        {
            return this._Documentos_MultimediaRepository.Table.ToList();
        }

        public IList<Core.Domain.Documentos_Multimedia.Documentos_Multimedia> SelAllComplete(bool ConRelaciones)
        {
            return this._Documentos_MultimediaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Documentos_MultimediaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Documentos_MultimediaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Documentos_MultimediaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Documentos_Multimedia.Documentos_MultimediaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Documentos_MultimediaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Documentos_MultimediaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Documentos_MultimediaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia entity, Spartane.Core.Domain.User.GlobalData Documentos_MultimediaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia entity, Spartane.Core.Domain.User.GlobalData Documentos_MultimediaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

