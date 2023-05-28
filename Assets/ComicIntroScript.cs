using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComicIntroScript : MonoBehaviour
{
    //public List<GameObject> comicPanelNextButton;
    public List<Sprite> comicPanel = new List<Sprite>();
    // Start is called before the first frame update
    public int index = 0;

    Image comicPanelImage;
    Button buttonNextComicPanel;
    Button buttonPrevComicPanel;
    //public SceneDataHandler sceneManager;

    void Start()
    {
        //ComicPanel = 
        comicPanelImage = GameObject.Find("ComicPanelImage").GetComponent<Image>();
        buttonNextComicPanel = GameObject.Find("ComicNextButton").GetComponent<Button>();
        buttonPrevComicPanel = GameObject.Find("ComicPrevButton").GetComponent<Button>();

        UpdatePanelPage();
        addButtonListeners();

    }

    // Update is called once per frame
    void UpdatePanelPage()
    {
        comicPanelImage.sprite = comicPanel[index];

    }

    void addButtonListeners(){
        buttonNextComicPanel.onClick.AddListener(nextPage);
        buttonPrevComicPanel.onClick.AddListener(prevPage);
    }

    void prevPage(){
        if (index>0){
                    index--;
                    UpdatePanelPage();
            }
    }
    void nextPage(){
        if (index<(comicPanel.Count-1)){
                    index++;
                    UpdatePanelPage();
            }
        
        if (index==(comicPanel.Count-1)){
            //SceneManager.LoadScene("MainMenu");
        }
    }


}
