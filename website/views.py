from django.shortcuts import render

def homepage(request):
    title = 'Kun Deng'
    return render(request, 'homepage.html', {'title':title})

def contact(request):
    title = 'Kun Deng - Contact'
    return render(request, 'contact.html', {'title':title})
