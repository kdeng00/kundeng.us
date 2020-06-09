from django.http import HttpResponse
from django.shortcuts import render

def test(request):
    return HttpResponse("this is a test")

def home(request):
    return render(request, 'website/home.html')
