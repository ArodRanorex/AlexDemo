﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest10222020
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest10222020Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("c6e486f1-5bd8-42fa-a393-a11dee66fb8c")]
    public partial class MyTest10222020Repository : RepoGenBaseFolder
    {
        static MyTest10222020Repository instance = new MyTest10222020Repository();
        MyTest10222020RepositoryFolders.RxMainFrameAppFolder _rxmainframe;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest10222020Repository element repository.
        /// </summary>
        [RepositoryFolder("c6e486f1-5bd8-42fa-a393-a11dee66fb8c")]
        public static MyTest10222020Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest10222020Repository() 
            : base("MyTest10222020Repository", "/", null, 0, false, "c6e486f1-5bd8-42fa-a393-a11dee66fb8c", ".\\RepositoryImages\\MyTest10222020Repositoryc6e486f1.rximgres")
        {
            _rxmainframe = new MyTest10222020RepositoryFolders.RxMainFrameAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("c6e486f1-5bd8-42fa-a393-a11dee66fb8c")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("9975bd99-8edb-4326-8b53-b895d99a12d9")]
        public virtual MyTest10222020RepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest10222020RepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("9975bd99-8edb-4326-8b53-b895d99a12d9")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _enteryournameInfo;
            RepoItemInfo _btnsubmitusernameInfo;
            RepoItemInfo _lblwelcomemessageInfo;
            RepoItemInfo _resetInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@controlname='RxMainFrame']", parentFolder, 30000, null, false, "9975bd99-8edb-4326-8b53-b895d99a12d9", "")
            {
                _enteryournameInfo = new RepoItemInfo(this, "EnterYourName", ".//text[@accessiblename='Enter your name' and @accessiblerole='Text']", 30000, null, "e7f23649-8572-427e-9d95-d1d5c2f2ca95");
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", ".//button[@controlname='btnSubmitUserName']", 30000, null, "a043e72a-b0b2-4d21-b54b-04dff2c2c3da");
                _lblwelcomemessageInfo = new RepoItemInfo(this, "LblWelcomeMessage", ".//text[@controlname='lblWelcomeMessage']", 30000, null, "715044b3-92fc-46ce-aa71-72797c5bfae4");
                _resetInfo = new RepoItemInfo(this, "Reset", "?/?/tabpage[@controlname='RxTabIntroduction']//link[@accessiblename='Reset']", 30000, null, "8bcb4f6f-6ab1-4746-bd51-0fd6cba5a9be");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9975bd99-8edb-4326-8b53-b895d99a12d9")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9975bd99-8edb-4326-8b53-b895d99a12d9")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The EnterYourName item.
            /// </summary>
            [RepositoryItem("e7f23649-8572-427e-9d95-d1d5c2f2ca95")]
            public virtual Ranorex.Text EnterYourName
            {
                get
                {
                    return _enteryournameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterYourName item info.
            /// </summary>
            [RepositoryItemInfo("e7f23649-8572-427e-9d95-d1d5c2f2ca95")]
            public virtual RepoItemInfo EnterYourNameInfo
            {
                get
                {
                    return _enteryournameInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("a043e72a-b0b2-4d21-b54b-04dff2c2c3da")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("a043e72a-b0b2-4d21-b54b-04dff2c2c3da")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }

            /// <summary>
            /// The LblWelcomeMessage item.
            /// </summary>
            [RepositoryItem("715044b3-92fc-46ce-aa71-72797c5bfae4")]
            public virtual Ranorex.Text LblWelcomeMessage
            {
                get
                {
                    return _lblwelcomemessageInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LblWelcomeMessage item info.
            /// </summary>
            [RepositoryItemInfo("715044b3-92fc-46ce-aa71-72797c5bfae4")]
            public virtual RepoItemInfo LblWelcomeMessageInfo
            {
                get
                {
                    return _lblwelcomemessageInfo;
                }
            }

            /// <summary>
            /// The Reset item.
            /// </summary>
            [RepositoryItem("8bcb4f6f-6ab1-4746-bd51-0fd6cba5a9be")]
            public virtual Ranorex.Link Reset
            {
                get
                {
                    return _resetInfo.CreateAdapter<Ranorex.Link>(true);
                }
            }

            /// <summary>
            /// The Reset item info.
            /// </summary>
            [RepositoryItemInfo("8bcb4f6f-6ab1-4746-bd51-0fd6cba5a9be")]
            public virtual RepoItemInfo ResetInfo
            {
                get
                {
                    return _resetInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
