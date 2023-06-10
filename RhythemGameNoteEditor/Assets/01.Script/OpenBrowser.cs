using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleFileBrowser;

public class OpenBrowser : MonoBehaviour
{
    public void MusicLoadBrowser()
    {
        SetBrowser(0);
    }
    public void TextLoadBrowser()
    {
        SetBrowser(1);
    }
    private void SetBrowser(int t)
    {
        if (t == 0)
        {
            FileBrowser.SetFilters(true, new FileBrowser.Filter("Audios", ".mp3", ".wav"));
        }
        if (t == 1)
        {
            FileBrowser.SetFilters(true, new FileBrowser.Filter("Text Files", ".txt"));
        }
        FileBrowser.SetDefaultFilter(".jpg");
        FileBrowser.SetExcludedExtensions(".lnk", ".tmp", ".zip", ".rar", ".exe");
        FileBrowser.AddQuickLink("Users", "C:\\Users", null);
        StartCoroutine(ShowLoadDialogCoroutine(t));
    }

    IEnumerator ShowLoadDialogCoroutine(int t)
    {
        yield return FileBrowser.WaitForLoadDialog(FileBrowser.PickMode.FilesAndFolders, true, null, null, "Load Files and Folders", "Load");
        

        if (FileBrowser.Success)
        {
            for (int i = 0; i < FileBrowser.Result.Length; i++)
                Debug.Log(FileBrowser.Result[i]);

            byte[] bytes = FileBrowserHelpers.ReadBytesFromFile(FileBrowser.Result[0]);

            string destinationPath = Path.Combine(Application.persistentDataPath, FileBrowserHelpers.GetFilename(FileBrowser.Result[0]));
            FileBrowserHelpers.CopyFile(FileBrowser.Result[0], destinationPath);
        }
    }
}
