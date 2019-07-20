﻿using System;
using Android.Gms.Tasks;
using eplant.Droid.Services;
using Xamarin.Forms;
using eplant.Services;
using eplant.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using eplant.Helpers;
using Firebase.Storage;
using Xamarin.Essentials;

[assembly: Dependency(typeof(FirebaseConnection_Droid))]
namespace eplant.Droid.Services
{
    public class FirebaseConnection_Droid : Java.Lang.Object, IFirebaseConnection, IOnSuccessListener, IOnFailureListener
    {

        #region Methods

        public async System.Threading.Tasks.Task saveImage(Stream imgStream, string nameImage)
        {
            try
            {
                if(Connectivity.NetworkAccess == NetworkAccess.Internet)
                {
                    FirebaseStorage storage = FirebaseStorage.Instance;
                    StorageReference storageRef = storage.GetReferenceFromUrl("gs://eplant-947b2.appspot.com/Plantas");
                    StorageReference imageRef = storageRef.Child(nameImage);
                    imageRef.PutStream(imgStream).AddOnSuccessListener(this).AddOnFailureListener(this);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogAndSendException(this, nameof(saveImage), ex);
            }
        }
        public void OnFailure(Java.Lang.Exception e)
        {
            throw new NotImplementedException();
        }

        public void OnSuccess(Java.Lang.Object result)
        {
            System.Console.WriteLine(result.ToString());
        }

        public Task<List<RegistroPlanta>> PostRegisterPlantAsync(RegisterPlantModel model)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}