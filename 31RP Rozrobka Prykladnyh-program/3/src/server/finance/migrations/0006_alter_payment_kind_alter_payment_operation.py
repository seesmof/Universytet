# Generated by Django 5.1.3 on 2024-11-19 18:43

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('finance', '0005_payment_kind_payment_operation'),
    ]

    operations = [
        migrations.AlterField(
            model_name='payment',
            name='kind',
            field=models.CharField(choices=[('Single', 'Single'), ('Periodic', 'Periodic')], max_length=12),
        ),
        migrations.AlterField(
            model_name='payment',
            name='operation',
            field=models.CharField(choices=[('Withdrawal', 'Withdrawal'), ('Deposit', 'Deposit')], max_length=12),
        ),
    ]
