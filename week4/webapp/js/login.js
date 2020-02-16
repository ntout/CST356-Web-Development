

$('#test').click(function(){
    $('.login-input input').each(function(){
        if(this.value != ""){ 
            $(this).next().hide()
        }
        else if(this.value == ""){
            console.log(this.name + ' is empty')
            $(this).next().show()
        }
        console.log(this.value)
    })
    console.log('submit btn clicked')
})

function initialValidation(){
    $('.validation-message').hide();
}


