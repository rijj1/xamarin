﻿using System;
using Android;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using AndroidX.Activity.Result;
using AndroidX.Activity.Result.Contract;
using AndroidX.AppCompat.App;
using AndroidX.Core.Content;
using Com.Canhub.Cropper;
using Java.IO;
using QuickDate.Helpers.Utils;
using Uri = Android.Net.Uri;

namespace QuickDate.Helpers.Controller
{
    public class DialogGalleryController
    {
        private readonly AppCompatActivity Activity;
        private readonly IActivityResultCallback Callback;

        private ActivityResultLauncher PickMedia;
        private bool AllowMultiple;
        private bool AllowCropping;

        public string ImageType;

        public DialogGalleryController(AppCompatActivity activity, IActivityResultCallback callback, bool allowMultiple = false, bool imageCropping = true)
        {
            try
            {
                Activity = activity;
                Callback = callback;
                AllowMultiple = allowMultiple;
                AllowCropping = imageCropping;

                if (imageCropping)
                {
                    InitCropImage(activity);
                }
                else
                {
                    if (IsPhotoPickerAvailable())
                        PickMedia = activity.RegisterForActivityResult(allowMultiple ? new ActivityResultContracts.PickMultipleVisualMedia(9) : new ActivityResultContracts.PickVisualMedia(), Callback);
                    else
                        InitCropImage(activity);
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        public static bool IsPhotoPickerAvailable()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Tiramisu)
            {
                return true;
            }
            else if (Build.VERSION.SdkInt >= BuildVersionCodes.R)
            {
                return Android.OS.Ext.SdkExtensions.GetExtensionVersion((int)BuildVersionCodes.R) >= 2;
            }
            else
                return false;
        }

        #region PickVisualMedia

        public void OpenPickVisualMedia(string mediaType = "All", bool allowMultiple = false)
        {
            try
            {
                if (mediaType == "All")
                {
                    // Launch the photo picker and allow the user to choose images and videos.
                    PickMedia.Launch(new PickVisualMediaRequest.Builder()
                        .SetMediaType(ActivityResultContracts.PickVisualMedia.ImageAndVideo.Instance)
                        .Build());
                }
                else if (mediaType == "Video")
                {
                    // Launch the photo picker and allow the user to choose videos.
                    PickMedia.Launch(new PickVisualMediaRequest.Builder()
                        .SetMediaType(ActivityResultContracts.PickVisualMedia.VideoOnly.Instance)
                        .Build());
                }
                else if (mediaType == "Image")
                {
                    // Launch the photo picker and allow the user to choose images
                    PickMedia.Launch(new PickVisualMediaRequest.Builder()
                        .SetMediaType(ActivityResultContracts.PickVisualMedia.ImageOnly.Instance)
                        .Build());
                }
                else
                {
                    // Launch the photo picker and allow the user to choose all.
                    PickMedia.Launch(new PickVisualMediaRequest.Builder()
                        .SetMediaType(new ActivityResultContracts.PickVisualMedia.SingleMimeType("*/*"))
                        .Build());
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        #endregion

        #region CropImage

        private void InitCropImage(AppCompatActivity activity)
        {
            try
            {
                PickMedia = activity.RegisterForActivityResult(new CropImageContract(), Callback);
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        public void OpenDialogGallery(string typeImage = "")
        {
            try
            {
                ImageType = typeImage;

                // Check if we're running on Android 5.0 or higher
                if ((int)Build.VERSION.SdkInt < 23)
                {
                    Methods.Path.Chack_MyFolder();
                    var myUri = Android.Net.Uri.FromFile(new File(Methods.Path.FolderDiskImage, Methods.GetTimestamp(DateTime.Now) + ".jpg"));
                    var option = new CropImageContractOptions(null, new CropImageOptions()
                    {
                        ImageSourceIncludeGallery = true,
                        ImageSourceIncludeCamera = true,
                        ShowIntentChooser = true,
                        ActivityBackgroundColor = Color.Black,
                        AllowFlipping = true,
                        AllowRotation = true,
                        Guidelines = CropImageView.Guidelines.On,
                        MaxZoom = 4,
                        OutputCompressFormat = Bitmap.CompressFormat.Jpeg,
                    });
                    //Open Image 
                    PickMedia.Launch(option);
                }
                else
                {
                    if (PermissionsController.CheckPermissionStorage(Activity, "image") && ContextCompat.CheckSelfPermission(Activity, Manifest.Permission.Camera) == Permission.Granted)
                    {
                        Methods.Path.Chack_MyFolder();

                        var myUri = Android.Net.Uri.FromFile(new File(Methods.Path.FolderDiskImage, Methods.GetTimestamp(DateTime.Now) + ".jpg"));
                        var option = new CropImageContractOptions(null, new CropImageOptions()
                        {
                            ImageSourceIncludeGallery = true,
                            ImageSourceIncludeCamera = true,
                            ShowIntentChooser = true,
                            ActivityBackgroundColor = Color.Black,
                            AllowFlipping = true,
                            AllowRotation = true,
                            Guidelines = CropImageView.Guidelines.On,
                            MaxZoom = 4,
                            OutputCompressFormat = Bitmap.CompressFormat.Jpeg,
                        });
                        //Open Image 
                        PickMedia.Launch(option);
                    }
                    else
                    {
                        new PermissionsController(Activity).RequestPermission(108, "image");
                    }
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        public void OpenCropDialog(Uri myUri)
        {
            try
            {
                // Check if we're running on Android 5.0 or higher
                if ((int)Build.VERSION.SdkInt < 23)
                {
                    Methods.Path.Chack_MyFolder();

                    var option = new CropImageContractOptions(myUri, new CropImageOptions()
                    {
                        ImageSourceIncludeGallery = false,
                        ImageSourceIncludeCamera = false,
                        ShowIntentChooser = false,
                        ActivityBackgroundColor = Color.Black,
                        AllowFlipping = true,
                        AllowRotation = true,
                        Guidelines = CropImageView.Guidelines.On,
                        MaxZoom = 4,
                        OutputCompressFormat = Bitmap.CompressFormat.Jpeg,
                    });
                    //Open Image 
                    PickMedia.Launch(option);
                }
                else
                {
                    if (PermissionsController.CheckPermissionStorage(Activity, "image") && ContextCompat.CheckSelfPermission(Activity, Manifest.Permission.Camera) == Permission.Granted)
                    {
                        Methods.Path.Chack_MyFolder();

                        var option = new CropImageContractOptions(myUri, new CropImageOptions()
                        {
                            ImageSourceIncludeGallery = false,
                            ImageSourceIncludeCamera = false,
                            ShowIntentChooser = false,
                            ActivityBackgroundColor = Color.Black,
                            AllowFlipping = true,
                            AllowRotation = true,
                            Guidelines = CropImageView.Guidelines.On,
                            MaxZoom = 4,
                            OutputCompressFormat = Bitmap.CompressFormat.Jpeg,
                        });
                        //Open Image 
                        PickMedia.Launch(option);
                    }
                    else
                    {
                        new PermissionsController(Activity).RequestPermission(108, "image");
                    }
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        #endregion

    }
}
