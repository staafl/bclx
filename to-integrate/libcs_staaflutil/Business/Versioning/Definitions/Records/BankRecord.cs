using System;
namespace Versioning
{

    public class BankRecord : Sage_Container, ILinkRecord
    {
        /* Autogenerated by sage_wrapper_generator.pl */
        SageDataObject110.BankRecord br11;
        SageDataObject120.BankRecord br12;
        SageDataObject130.BankRecord br13;
        SageDataObject140.BankRecord br14;
        SageDataObject150.BankRecord br15;
        SageDataObject160.BankRecord br16;
        SageDataObject170.BankRecord br17;


        public BankRecord(object inner, int version)
            : base(version) {
            switch (m_version) {
                case 11: {
                        br11 = (SageDataObject110.BankRecord)inner;
                        m_fields = new Fields(br11.Fields, m_version);
                        return;
                    }

                case 12: {
                        br12 = (SageDataObject120.BankRecord)inner;
                        m_fields = new Fields(br12.Fields, m_version);
                        return;
                    }

                case 13: {
                        br13 = (SageDataObject130.BankRecord)inner;
                        m_fields = new Fields(br13.Fields, m_version);
                        return;
                    }

                case 14: {
                        br14 = (SageDataObject140.BankRecord)inner;
                        m_fields = new Fields(br14.Fields, m_version);
                        return;
                    }

                case 15: {
                        br15 = (SageDataObject150.BankRecord)inner;
                        m_fields = new Fields(br15.Fields, m_version);
                        return;
                    }
                case 16: {
                        br16 = (SageDataObject160.BankRecord)inner;
                        m_fields = new Fields(br16.Fields, m_version);
                        return;
                    }
                case 17: {
                        br17 = (SageDataObject170.BankRecord)inner;
                        m_fields = new Fields(br17.Fields, m_version);
                        return;
                    }

                default: throw new InvalidOperationException("ver");
            }
        }
        /* Autogenerated with record_generator.pl */
        const string ACCOUNT_REF = "ACCOUNT_REF";
        const string BANKRECORD = "BankRecord";


        public bool AddNew() {
            bool ret;
            switch (m_version) {
                case 11: {
                        ret = br11.AddNew();
                        break;
                    }

                case 12: {
                        ret = br12.AddNew();
                        break;
                    }

                case 13: {
                        ret = br13.AddNew();
                        break;
                    }

                case 14: {
                        ret = br14.AddNew();
                        break;
                    }

                case 15: {
                        ret = br15.AddNew();
                        break;
                    }
                case 16: {
                        ret = br16.AddNew();
                        break;
                    }
                case 17: {
                        ret = br17.AddNew();
                        break;
                    }

                default: throw new InvalidOperationException("ver");
            }
            return ret;
        }
        public bool Update() {
            bool ret;
            switch (m_version) {
                case 11: {
                        ret = br11.Update();
                        break;
                    }

                case 12: {
                        ret = br12.Update();
                        break;
                    }

                case 13: {
                        ret = br13.Update();
                        break;
                    }

                case 14: {
                        ret = br14.Update();
                        break;
                    }

                case 15: {
                        ret = br15.Update();
                        break;
                    }
                case 16: {
                        ret = br16.Update();
                        break;
                    }
                case 17: {
                        ret = br17.Update();
                        break;
                    }

                default: throw new InvalidOperationException("ver");
            }
            return ret;
        }
        public bool Edit() {
            bool ret;
            switch (m_version) {
                case 11: {
                        ret = br11.Edit();
                        break;
                    }

                case 12: {
                        ret = br12.Edit();
                        break;
                    }

                case 13: {
                        ret = br13.Edit();
                        break;
                    }

                case 14: {
                        ret = br14.Edit();
                        break;
                    }

                case 15: {
                        ret = br15.Edit();
                        break;
                    }
                case 16: {
                        ret = br16.Edit();
                        break;
                    }
                case 17: {
                        ret = br17.Edit();
                        break;
                    }

                default: throw new InvalidOperationException("ver");
            }
            return ret;
        }
        public bool Find(bool partial) {
            bool ret;
            switch (m_version) {
                case 11: {
                        ret = br11.Find(partial);
                        break;
                    }

                case 12: {
                        ret = br12.Find(partial);
                        break;
                    }

                case 13: {
                        ret = br13.Find(partial);
                        break;
                    }

                case 14: {
                        ret = br14.Find(partial);
                        break;
                    }

                case 15: {
                        ret = br15.Find(partial);
                        break;
                    }
                case 16: {
                        ret = br16.Find(partial);
                        break;
                    }
                case 17: {
                        ret = br17.Find(partial);
                        break;
                    }

                default: throw new InvalidOperationException("ver");
            }
            return ret;
        }
        public bool MoveFirst() {
            bool ret;
            switch (m_version) {
                case 11: {
                        ret = br11.MoveFirst();
                        break;
                    }

                case 12: {
                        ret = br12.MoveFirst();
                        break;
                    }

                case 13: {
                        ret = br13.MoveFirst();
                        break;
                    }

                case 14: {
                        ret = br14.MoveFirst();
                        break;
                    }

                case 15: {
                        ret = br15.MoveFirst();
                        break;
                    }
                case 16: {
                        ret = br16.MoveFirst();
                        break;
                    }
                case 17: {
                        ret = br17.MoveFirst();
                        break;
                    }

                default: throw new InvalidOperationException("ver");
            }
            return ret;
        }
        public bool MoveNext() {
            bool ret;
            switch (m_version) {
                case 11: {
                        ret = br11.MoveNext();
                        break;
                    }

                case 12: {
                        ret = br12.MoveNext();
                        break;
                    }

                case 13: {
                        ret = br13.MoveNext();
                        break;
                    }

                case 14: {
                        ret = br14.MoveNext();
                        break;
                    }

                case 15: {
                        ret = br15.MoveNext();
                        break;
                    }
                case 16: {
                        ret = br16.MoveNext();
                        break;
                    }
                case 17: {
                        ret = br17.MoveNext();
                        break;
                    }

                default: throw new InvalidOperationException("ver");
            }
            return ret;
        }
        public bool MoveLast() {
            bool ret;
            switch (m_version) {
                case 11: {
                        ret = br11.MoveLast();
                        break;
                    }

                case 12: {
                        ret = br12.MoveLast();
                        break;
                    }

                case 13: {
                        ret = br13.MoveLast();
                        break;
                    }

                case 14: {
                        ret = br14.MoveLast();
                        break;
                    }

                case 15: {
                        ret = br15.MoveLast();
                        break;
                    }
                case 16: {
                        ret = br16.MoveLast();
                        break;
                    }
                case 17: {
                        ret = br17.MoveLast();
                        break;
                    }

                default: throw new InvalidOperationException("ver");
            }
            return ret;
        }
        public bool MovePrev() {
            bool ret;
            switch (m_version) {
                case 11: {
                        ret = br11.MovePrev();
                        break;
                    }

                case 12: {
                        ret = br12.MovePrev();
                        break;
                    }

                case 13: {
                        ret = br13.MovePrev();
                        break;
                    }

                case 14: {
                        ret = br14.MovePrev();
                        break;
                    }

                case 15: {
                        ret = br15.MovePrev();
                        break;
                    }
                case 16: {
                        ret = br16.MovePrev();
                        break;
                    }
                case 17: {
                        ret = br17.MovePrev();
                        break;
                    }

                default: throw new InvalidOperationException("ver");
            }
            return ret;
        }
        public bool CanRemove() {
            bool ret;
            switch (m_version) {
                case 11: {
                        ret = br11.CanRemove();
                        break;
                    }

                case 12: {
                        ret = br12.CanRemove();
                        break;
                    }

                case 13: {
                        ret = br13.CanRemove();
                        break;
                    }

                case 14: {
                        ret = br14.CanRemove();
                        break;
                    }

                case 15: {
                        ret = br15.CanRemove();
                        break;
                    }
                case 16: {
                        ret = br16.CanRemove();
                        break;
                    }
                case 17: {
                        ret = br17.CanRemove();
                        break;
                    }

                default: throw new InvalidOperationException("ver");
            }
            return ret;
        }
        public bool Remove() {
            bool ret;
            switch (m_version) {
                case 11: {
                        ret = br11.Remove();
                        break;
                    }

                case 12: {
                        ret = br12.Remove();
                        break;
                    }

                case 13: {
                        ret = br13.Remove();
                        break;
                    }

                case 14: {
                        ret = br14.Remove();
                        break;
                    }

                case 15: {
                        ret = br15.Remove();
                        break;
                    }
                case 16: {
                        ret = br16.Remove();
                        break;
                    }
                case 17: {
                        ret = br17.Remove();
                        break;
                    }

                default: throw new InvalidOperationException("ver");
            }
            return ret;
        }
        public object Link {
            get {
                object ret;
                switch (m_version) {
                    case 11: {
                            ret = br11.Link;
                            break;
                        }

                    case 12: {
                            ret = br12.Link;
                            break;
                        }

                    case 13: {
                            ret = br13.Link;
                            break;
                        }

                    case 14: {
                            ret = br14.Link;
                            break;
                        }

                    case 15: {
                            ret = br15.Link;
                            break;
                        }
                    case 16: {
                            ret = br16.Link;
                            break;
                        }
                    case 17: {
                            ret = br17.Link;
                            break;
                        }

                    default: throw new InvalidOperationException("ver");
                }
                return ret;
            }
            set {
                switch (m_version) {
                    case 11: {
                            br11.Link = value;
                            break;
                        }

                    case 12: {
                            br12.Link = value;
                            break;
                        }

                    case 13: {
                            br13.Link = value;
                            break;
                        }

                    case 14: {
                            br14.Link = value;
                            break;
                        }

                    case 15: {
                            br15.Link = value;
                            break;
                        }
                    case 16: {
                            br16.Link = value;
                            break;
                        }
                    case 17: {
                            br17.Link = value;
                            break;
                        }

                }
            }
        }
        public int Count {
            get {
                int ret;
                switch (m_version) {
                    case 11: {
                            ret = br11.Count;
                            break;
                        }

                    case 12: {
                            ret = br12.Count;
                            break;
                        }

                    case 13: {
                            ret = br13.Count;
                            break;
                        }

                    case 14: {
                            ret = br14.Count;
                            break;
                        }

                    case 15: {
                            ret = br15.Count;
                            break;
                        }
                    case 16: {
                            ret = br16.Count;
                            break;
                        }
                    case 17: {
                            ret = br17.Count;
                            break;
                        }

                    default: throw new InvalidOperationException("ver");
                }
                return ret;
            }
            set {
                switch (m_version) {
                    case 11: {
                            br11.Count = value;
                            break;
                        }

                    case 12: {
                            br12.Count = value;
                            break;
                        }

                    case 13: {
                            br13.Count = value;
                            break;
                        }

                    case 14: {
                            br14.Count = value;
                            break;
                        }

                    case 15: {
                            br15.Count = value;
                            break;
                        }
                    case 16: {
                            br16.Count = value;
                            break;
                        }
                    case 17: {
                            br17.Count = value;
                            break;
                        }

                }
            }
        }
    }
}
