function searchTracks(keyword) {
    var transform2 = [
        {
            tag: 'tr', class: 'TODO', children: [
               //{tag:'td',href:function(){return(this);},children:[
               //    {"tag":"span","html":"${Title}"}
               //]},
               { tag: 'td', html: '${Artist}' },
               { tag: 'td', html: '${Album}' },
               { tag: 'td', html: '${Title}' },
               { tag: 'td', html: '${Genre}' },
               { tag: 'td', html: '${DurationSec}' },
               { tag: 'td', html: '${FileType}' },
               { tag: 'audio', preload: 'auto', controls: 'true', src: '${WebPath}' }

               //{tag:'button',onclick:function(){$('#deckA')[0].src = this['WebPath']; alert('hi');},html:'Deck A'},
               /*{
                   tag: 'td', class: 'TODO', children: [
                      { tag: 'button', onclick: function () { $('#deckB')[0].play(); }, html: 'Deck B' }
                   ]
               }*/
            ]
        }
    ];

    var transform = [
        { tag: 'audio', preload: 'auto', controls: 'true', src: '${WebPath}' },
        { tag: 'span', html: '${Artist} - ${Title}' },
		/*{ tag: 'button', onclick: function () { alert(JSON.stringify(current)); }, html: 'Deck A' },*/
        { tag: 'br' }
    ];

    console.log('About to make Ajax call for searchTracks(' + keyword + ')');
    var tmp = '';
    $.ajax({
        type: "GET",
        url: "/api/tracks/search/" + keyword,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            //var tmp = [];
            $.each(data, function (key, value) {
                //var dataline = value.TrackId + value.Album + value.Artist + value.Title + value.Year + value.Genre + value.DurationSec + value.FileType
                //tmp.push(dataline);
                //$('#jsondiv').json2html(value, transform, { 'events': true });
                tmp = tmp + key + '<br />';
            });
            $('#jsondiv').html(tmp);
            console.log('  Success!');
        },
        error: function (data) {
            console.log('  Error occurred!');
            alert('error');
        }
    });
    console.log('  Ajax call complete.');
}
