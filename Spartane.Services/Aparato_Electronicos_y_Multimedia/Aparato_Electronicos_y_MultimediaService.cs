using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Aparato_Electronicos_y_Multimedia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Aparato_Electronicos_y_MultimediaService : IAparato_Electronicos_y_MultimediaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> _Aparato_Electronicos_y_MultimediaRepository;
        #endregion

        #region Ctor
        public Aparato_Electronicos_y_MultimediaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> Aparato_Electronicos_y_MultimediaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Aparato_Electronicos_y_MultimediaRepository = Aparato_Electronicos_y_MultimediaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> SelAll(bool ConRelaciones)
        {
            return this._Aparato_Electronicos_y_MultimediaRepository.Table.ToList();
        }

        public IList<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> SelAllComplete(bool ConRelaciones)
        {
            return this._Aparato_Electronicos_y_MultimediaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Aparato_Electronicos_y_MultimediaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Aparato_Electronicos_y_MultimediaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Aparato_Electronicos_y_MultimediaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_MultimediaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Aparato_Electronicos_y_MultimediaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Aparato_Electronicos_y_MultimediaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Aparato_Electronicos_y_MultimediaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia entity, Spartane.Core.Domain.User.GlobalData Aparato_Electronicos_y_MultimediaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia entity, Spartane.Core.Domain.User.GlobalData Aparato_Electronicos_y_MultimediaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

