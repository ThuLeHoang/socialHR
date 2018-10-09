using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nest;
using socialHR.Areas;
using socialHR.Areas.Employer.Models;

namespace socialHR.Areas.Employer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Employer/Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SocialCVPage(String string_to_req, String type_search)
        {
            //lay thong tin tu elastic search va tra ve data nguoi dung
            var settings = new ConnectionSettings(new Uri("http://192.168.1.207:9200")).DefaultIndex("fb_author_data");
            var client = new ElasticClient(settings);
            string field_to_search = "";
            switch (Int32.Parse(type_search))
            {
                case 1:
                    field_to_search = "fb_data.mobile_phone";
                    break;
                case 2:
                    field_to_search = "username";
                    break;
                case 3:
                    field_to_search = "id";
                    break;
            }

            // "_type": "authordata"
            var sResponse = client.Search<AuthorData>(s => s
            .From(0).Size(1)
            .Query(q => q
                .Bool(b => b
                    .Must(mu => mu
                        .MatchPhrase(m => m.Field(field_to_search).Query(string_to_req))
                    )
                 )
            )
            );
            AuthorData data = new AuthorData();
            foreach (var info in sResponse.Hits)
            {
                data = info.Source;
            }

            socialNetwork social = new socialNetwork();
            social.most_interactive_friend = new List<AuthorData>();
            social.high_influencer_score_friend = new List<AuthorData>();
            social.fb_group = new List<fbGroup>();
            social.fb_post = new List<fbPost>();
            social.fb_comment = new List<fbComment>();
            social.fb_fanpage = new List<fbFanpage>();

            /*************************************fake data***********************************/
            fbGroup grtemp = new fbGroup();
            fbPost ptemp = new fbPost();
            fbPost ptemp2 = new fbPost();
            fbComment ctemp = new fbComment();
            fbFanpage ftemp = new fbFanpage();


            //fake friend data
            var sResponse_fake_friend = client.Search<AuthorData>(s => s

            .Query(q => q
            .Bool(b => b
            .Must(mu => mu
            .Match(
                m => m.Field("author_name").Query("Trần Tiểu Vy")
            )
            )
            )
            )
            );
            foreach (var info in sResponse_fake_friend.Hits)
            {
                social.most_interactive_friend.Add(info.Source);
            }


            var sResponse_fake_friend_2 = client.Search<AuthorData>(s => s

            .Query(q => q
            .Bool(b => b
            .Must(mu => mu
            .Match(
                m => m.Field("educationLevel").Query("3")
            )
            )
            )
            ).Sort(ss => ss.Descending(m => m.influence_score))
            );
            foreach (var info in sResponse_fake_friend_2.Hits)
            {
                social.high_influencer_score_friend.Add(info.Source);
            }
            //end fake friend data

            grtemp.num_comment = 2;
            grtemp.num_like = 2;
            grtemp.avartar_url = "https://scontent.fhan4-1.fna.fbcdn.net/v/t1.0-1/p40x40/29597294_118000972380768_7947931011101229680_n.jpg?_nc_cat=105&oh=595979bbea9d08abb3e7ea8732aee6a6&oe=5C1C7139";
            grtemp.name = "Xôi lạc bánh khúc";
            grtemp.group_url = "https://www.facebook.com/groups/xoilac/";

            ptemp2.author_name = data.Name;
            ptemp2.content = "Một bài post nào đó";
            ptemp2.influence_score = 6;
            ptemp2.num_like = "100";
            ptemp2.num_comment = "100";
            ptemp2.time_post = DateTime.Now.ToString("h:mm:ss tt");
            ptemp2.url = "https://www.facebook.com/elastic.co/?__tn__=kC-R&eid=ARABVYV-W0Ry2Jz0TY1Xt0iJuLT4f656w70jhreXfaAStQ1wAXQHuth_BrZ5u8r0Fp3wL76LiZnmmgI21_VxYOzIwODA7eMer9unPR8&hc_ref=ARQURFQ5Ix2hCmCnl_B6P9KnPJhUYg7lw9BE7MBpuHhbE8JnY1bRklAODoJ2NUm8pP8&fref=nf&__xts__%5B0%5D=68.ARBfQoh81KH580yiS0mT6y5ApnmDU5OwsH0gGuIy53lTsVo3JGc5RssQIrk55FGtkpI0wja5NTSkLFM8Xov6b-m-whUR8fkgo8-0jHWm63uubySHL9eNPMIn65PkUOjreb-eRfngIgtVT9NcmIy3LuZc5tkoGgbBnYBQ5bIp5h1kibRkf439wjKAFWFydYoOYA";

            ptemp.author_name = data.Name;
            ptemp.content = "Ahihi mình làm hoa hậu rồi";
            ptemp.influence_score = 6;
            ptemp.num_like = "100";
            ptemp.num_comment = "100";
            ptemp.time_post = DateTime.Now.ToString("h:mm:ss tt");
            ptemp.url = "https://www.facebook.com/elastic.co/?__tn__=kC-R&eid=ARABVYV-W0Ry2Jz0TY1Xt0iJuLT4f656w70jhreXfaAStQ1wAXQHuth_BrZ5u8r0Fp3wL76LiZnmmgI21_VxYOzIwODA7eMer9unPR8&hc_ref=ARQURFQ5Ix2hCmCnl_B6P9KnPJhUYg7lw9BE7MBpuHhbE8JnY1bRklAODoJ2NUm8pP8&fref=nf&__xts__%5B0%5D=68.ARBfQoh81KH580yiS0mT6y5ApnmDU5OwsH0gGuIy53lTsVo3JGc5RssQIrk55FGtkpI0wja5NTSkLFM8Xov6b-m-whUR8fkgo8-0jHWm63uubySHL9eNPMIn65PkUOjreb-eRfngIgtVT9NcmIy3LuZc5tkoGgbBnYBQ5bIp5h1kibRkf439wjKAFWFydYoOYA";

            ftemp.num_comment = 2;
            ftemp.num_like = 2;
            ftemp.avartar_url = "https://scontent.fhan4-1.fna.fbcdn.net/v/t1.0-1/p40x40/29597294_118000972380768_7947931011101229680_n.jpg?_nc_cat=105&oh=595979bbea9d08abb3e7ea8732aee6a6&oe=5C1C7139";
            ftemp.name = "Xoilac.tv - Ăn xôi lạc xem bóng đá";
            ftemp.fanpage_url = "https://www.facebook.com/xoilacchamtv/";

            ctemp.content = "ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nèahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè - ahihi đây là một comment nè";
            ctemp.url = "https://www.facebook.com/elastic.co/?__tn__=kC-R&eid=ARABVYV-W0Ry2Jz0TY1Xt0iJuLT4f656w70jhreXfaAStQ1wAXQHuth_BrZ5u8r0Fp3wL76LiZnmmgI21_VxYOzIwODA7eMer9unPR8&hc_ref=ARQURFQ5Ix2hCmCnl_B6P9KnPJhUYg7lw9BE7MBpuHhbE8JnY1bRklAODoJ2NUm8pP8&fref=nf&__xts__%5B0%5D=68.ARBfQoh81KH580yiS0mT6y5ApnmDU5OwsH0gGuIy53lTsVo3JGc5RssQIrk55FGtkpI0wja5NTSkLFM8Xov6b-m-whUR8fkgo8-0jHWm63uubySHL9eNPMIn65PkUOjreb-eRfngIgtVT9NcmIy3LuZc5tkoGgbBnYBQ5bIp5h1kibRkf439wjKAFWFydYoOYA";

            social.fb_post.Add(ptemp);
            social.fb_post.Add(ptemp2);
            social.fb_group.Add(grtemp);
            social.fb_fanpage.Add(ftemp);
            social.fb_comment.Add(ctemp);
            /***********************************end fake data***********************************/

            ViewData["socialNetwork"] = social;
            ViewData["Message"] = data;
            if (data.Id == null || string_to_req == "" || string_to_req == null)
            {
                return RedirectToAction("not_found", "Home");
            }else
            {
                return View();
            }
        }
        
        public ActionResult search_page()
        {
            return View();
        }

        public ActionResult not_found()
        {
            return View();
        }
    }
}